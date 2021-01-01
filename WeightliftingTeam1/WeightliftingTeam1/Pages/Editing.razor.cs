﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telerik.Blazor.Components;
using WeightliftingTeam1.Models;

namespace WeightliftingTeam1.Pages
{
    public partial class Editing
    {
        public List<RecordTypes> RecordTypes { get; set; }

        int CurrentPage { get; set; } = 1;

        int PageSize { get; set; } = 11;

        
        protected override async Task OnInitializedAsync()
        {
            RecordTypes = await Task.Run(() => InitializeRecordTypes());
        }

        List<RecordTypes> InitializeRecordTypes()
        {
            RecordTypes = new List<RecordTypes>() { new RecordTypes {Id = 3, Name = "test"} };
            //RecordTypes = getDbDataService.getRecordTypes();
            return RecordTypes;
        }

        async Task EditHandler(GridCommandEventArgs args)
        {
            //IGridModel item = (IGridModel)args.Item;
        }

        async Task UpdateHandler(GridCommandEventArgs args)
        {
            /*
            IGridModel item = (IGridModel)args.Item;

            // perform actual data source operations here through your service
            await MyService.Update(item);

            // update the local view-model data with the service data
            await GetGridData();
            */
        }

        async Task DeleteHandler(GridCommandEventArgs args)
        {
            /*
            SampleData item = (SampleData)args.Item;

            // perform actual data source operation here through your service
            await MyService.Delete(item);

            // update the local view-model data with the service data
            await GetGridData();
            */

        }

        async Task CreateHandler(GridCommandEventArgs args)
        {
            /*
             SampleData item = (SampleData)args.Item;

             // perform actual data source operation here through your service
             await MyService.Create(item);

             // update the local view-model data with the service data
             await GetGridData();
            */
        }

        async Task CancelHandler(GridCommandEventArgs args)
        {
            /*
            SampleData item = (SampleData)args.Item;

            // if necessary, perform actual data source operation here through your service
            */
        }

    }
}