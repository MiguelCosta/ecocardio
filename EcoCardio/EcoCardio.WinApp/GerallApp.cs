﻿using EcoCardio.Repository;

namespace EcoCardio.WinApp
{
    public static class GerallApp
    {
        public static Repository.Abstract.IAppUnitOfWork AppRepository { get; set; }
    }
}
