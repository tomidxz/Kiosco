﻿using CommunityToolkit.Mvvm.Messaging.Messages;
using KioscoInformaticoServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KioscoInformaticoApp.Class
{
    ////CLASE QUE PORTA EL MENSAJE

    public class Message : ValueChangedMessage<string>
    {
        public Producto ProductoAEditar { get; set; }

        public Message(string value) : base(value)
        {

        }
    }
}
