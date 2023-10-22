﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Views
{
    internal interface IPayModeView
    {
        String PayModeId { get; set; }
        String PayModeName { get; set; }
        String PayModeObservation { get; set; }

        String searchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccesful { get; set; }
        String Message { get; set; }

        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        void setpayModeListBildingsource(BindingSource payModeList);
        void show();

    }
}
