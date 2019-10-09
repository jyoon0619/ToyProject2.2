/// <binding BeforeBuild='Run - Production, Profile - Development' Clean='Profile - Production' />
"use strict";

const path = require('path');
const webpack = require('webpack');
var fs = require('fs');
var projectRoot = path.resolve(__dirname);


module.exports = {
    //entry: {
    //    app: './wwwroot/js/site.js',
    //    HelloWorld: './Views/Home/HelloWorld.cshtml.js',
    //    EmployeeIndex: './Views/Home/EmployeeIndex.cshtml.js',
    //    PagesIndex: './Views/Pages/Index.cshtml.js',
    //    PagesCustomerList: './Views/Pages/CustomerList.cshtml.js',
    //    PagesCustomerDetail: './Views/Pages/CustomerDetail.cshtml.js',
    //    PagesSalesOrderList: './Views/Pages/SalesOrderList.cshtml.js'
    //},
    entry: () => {

        const ENTRYCONTAINER = "./Views";

        function getFiles(startPath) {

            var results = [];

            if (!fs.existsSync(startPath)) {
                console.log("no dir ", startPath);
                return;
            }

            var files = fs.readdirSync(startPath);
            for (var i = 0; i < files.length; i++) {
                var filename = path.join(startPath, files[i]);
                var stat = fs.lstatSync(filename);
                if (stat.isDirectory()) {
                    results = results.concat(getFiles(filename))
                }
                else if (filename.indexOf('.js') >= 0 && filename.indexOf('.dist.') == -1) {
                    results.push(filename);
                }
            }
            return results;
        };

        var entryPoints = {};

        getFiles(ENTRYCONTAINER).forEach(function (file) {

            entryPoints[file.replace('.js', '')] = './' + file;

        });

        return entryPoints;
    },
    plugins: [
        new webpack.DefinePlugin({
            'process.env.NODE_ENV': JSON.stringify('production')
        }),
        new webpack.NormalModuleReplacementPlugin(/element-ui[\/\\]lib[\/\\]locale[\/\\]lang[\/\\]zh-CN/, 'element-ui/lib/locale/lang/en'),
        new webpack.ProvidePlugin({
            '$': 'jquery',
            jQuery: 'jquery',
            jquery: 'jquery',
            'window.jQuery': 'jquery',
            Popper: ['popper.js', 'default'],
            moment: 'moment',
            axios: 'axios',
            numbro: 'numbro'
        }),
    ],
    output: {
        publicPath: "./",
        path: path.join(__dirname, '/wwwroot/js/'),
        filename: '[name].js'
    },
    //optimization: {
    //    splitChunks: {
    //        chunks: 'all',
    //    },
    //},
    module: {
        rules: [
            {
                test: /\.js$/,
                loader: 'babel-loader',
                exclude: /(node_modules)/,
                query: {
                    presets: ['es2015', "stage-2"]
                }
            },
            {
                test: /\.ts$/,
                exclude: /node_modules|vue\/src/,
                loader: "ts-loader",
                options: {
                    appendTsSuffixTo: [/\.vue$/]
                }
            },
            {
                test: /\.css$/,
                loaders: ['style-loader', 'css-loader'],
            },
            {
                test: /\.(png)$/i,
                loader: 'file-loader',
                options: {
                    outputPath: '../images/pkg/',   // image path
                    publicPath: '/images/pkg/',   // css path
                    useRelativePaths: false
                }
            },
            {
                test: /\.(gif|jpe?g|svg)$/i,
                use: [
                    'file-loader',
                    {
                        loader: 'image-webpack-loader',
                        options: {
                            mozjpeg: {
                                progressive: true,
                                quality: 65
                            },
                            // optipng.enabled: false will disable optipng
                            optipng: {
                                enabled: false,
                            },
                            pngquant: {
                                quality: '65-90',
                                speed: 4
                            },
                            gifsicle: {
                                interlaced: false,
                            },
                            // the webp option will enable WEBP
                            webp: {
                                quality: 75
                            }
                        }
                    },
                ],
            },
            {
                test: /\.(woff|ttf)$/,
                loader: 'url-loader',
                options: {
                    limit: 50000,
                    mimetype: 'application/font-woff',

                    // Output below the fonts directory
                    name: './fonts/[name].[ext]',

                    // Tweak publicPath to fix CSS lookups to take
                    // the directory into account.
                    publicPath: '../',
                }
            },
            {
                test: /\.vue$/,
                loader: 'vue-loader',
            }
        ]
    },
    devServer: {
        proxy: {
            '*': {
                target: 'http://localhost:54490',
                changeOrigin: true
            }
        }
    },
    resolve: {
        alias: {
            //vue: 'vue/dist/vue.js'
            vue: 'vue/dist/vue.min.js',
            'kendo': '@progress/kendo-ui/js/',
            'kendo': '@progress/kendo-theme-default'
        },
        extensions: ['.js', '.vue']
    },

};