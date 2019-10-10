<template>
    <div id="vueapp">
        <kendo-datasource ref="datasource1"
                          :transport-read-url="'https://demos.telerik.com/kendo-ui/service/Products'"
                          :transport-read-data-type="'jsonp'"
                          :transport-update-url="'https://demos.telerik.com/kendo-ui/service/Products/Update'"
                          :transport-update-data-type="'jsonp'"
                          :transport-destroy-url="'https://demos.telerik.com/kendo-ui/service/Products/Destroy'"
                          :transport-destroy-data-type="'jsonp'"
                          :transport-create-url="'https://demos.telerik.com/kendo-ui/service/Products/Create'"
                          :transport-create-data-type="'jsonp'"
                          :transport-parameter-map="parameterMap"
                          :schema-model-id="'ProductID'"
                          :schema-model-fields="schemaModelFields"
                          :batch='true'
                          :page-size='30'
                          :aggregate="aggregateDefinition">
        </kendo-datasource>

        <kendo-grid :height="600"
                    :data-source-ref="'datasource1'"
                    :reorderable="true"
                    :resizable="true"
                    :filterable="true"
                    :editable="'popup'"
                    :pageable="true"
                    :sortable-mode="'multiple'"
                    :groupable="true"
                    :sortable-allow-unsort="true"
                    :sortable-show-indexes="true"
                    :toolbar="['create','excel','pdf']"
                    :excel-file-name="'Kendo UI Grid Export.xlsx'"
                    :excel-filterable="true">
            <kendo-grid-column :field="'ProductName'"
                               :filterable-multi="true"
                               :filterable-search="true"
                               :width="300"
                               :attributes="{style: 'text-align: left'}"></kendo-grid-column>

            <kendo-grid-column :field="'UnitPrice'"
                               :title="'Unit Price'"
                               :width="130"
                               :headerAttributes="{style: 'text-align: right'}"
                               :attributes="{style: 'text-align: right'}"
                               :aggregates="['sum']"
                               :footer-template="'Total: #=kendo.toString(sum, `n2`)# '"
                               :group-footer-template="'Total: #=kendo.toString(sum, `n2`)# '"
                               :format="'{0:c}'"
                               :filterable-multi="true"></kendo-grid-column>
            <kendo-grid-column :field="'UnitsInStock'"
                               :title="'Units In Stock'"
                               :width="120"
                               :headerAttributes="{style: 'text-align: right'}"
                               :attributes="{style: 'text-align: right'}"
                               :aggregates="['count']"
                               :footer-template="'Count: #=count# '"
                               :filterable-multi="true"></kendo-grid-column>
            <kendo-grid-column :field="'Discontinued'"
                               :width="120"
                               :headerAttributes="{style: 'text-align: center'}"
                               :attributes="{style: 'text-align: center'}"
                               :filterable-multi="true"
                               :filterable-data-source="discontinuedDs"></kendo-grid-column>
            <kendo-grid-column :command="['edit', 'destroy']"
                               :title="'&nbsp;'"
                               :width="180"></kendo-grid-column>
        </kendo-grid>
    </div>
</template>

<script>

    import Vue from 'vue'
    import '@progress/kendo-ui';
    import { DataSource, HierarchicalDataSource, GanttDataSource, GanttDependencyDataSource, PivotDataSource, SchedulerDataSource, TreeListDataSource, DataSourceInstaller } from '@progress/kendo-datasource-vue-wrapper';
    import { Grid, GridColumn, GridInstaller } from '@progress/kendo-grid-vue-wrapper';
    import JSZip from 'jszip'

    Vue.use(GridInstaller);
    Vue.use(DataSourceInstaller);
    window.JSZip = JSZip


    export default {

        name: 'vueapp',

        data() {
            return {
                schemaModelFields: {
                    ProductID: { editable: false, nullable: true },
                    ProductName: { validation: { required: true } },
                    UnitPrice: { type: 'number', validation: { required: true, min: 1 } },
                    Discontinued: { type: 'boolean' },
                    UnitsInStock: { type: 'number', validation: { min: 0, required: true } }
                },
                discontinuedDs: [
                    { Discontinued: true },
                    { Discontinued: false }
                ],
                aggregateDefinition: [
                    { field: "UnitPrice", aggregate: "sum", },
                    { field: "UnitsInStock", aggregate: "count" }]
            }
        },
        methods: {
            parameterMap: function (options, operation) {
                if (operation !== 'read' && options.models) {
                    return { models: kendo.stringify(options.models) }
                }
            }
        }
    }
</script>


<style>
    .k-header .k-link {
        text-align: center;
    }
</style>