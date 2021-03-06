﻿using LinkerSharp.Common.Models;
using System.Collections.Generic;

namespace LinkerSharp.Common.Endpoints.FTP.IFaces
{
    public interface IFTPInConnector
    {
        /// <summary>
        /// Se encarga de la petición al servidor de FTP
        /// </summary>
        /// <param name="Endpoint">URL del servidor FTP.</param>
        /// <param name="StatusCode">Indica el código de estado concreto de la petición.</param>
        /// <param name="Data">Devuelve los datos requeridos si ha ido bien; en caso contrario devuelve la causa del error.</param>
        /// <returns>La petición se ha completado con éxito o no.</returns>
        bool GetData(string Endpoint, Dictionary<string, object> Params, out string StatusCode, out List<TransmissionMessageDTO> Data);
    }
}
