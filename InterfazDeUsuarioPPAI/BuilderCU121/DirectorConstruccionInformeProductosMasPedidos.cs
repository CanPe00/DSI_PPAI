using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using InterfazDeUsuarioPPAI.BusinessLayer.BuilderCU121;

namespace InterfazDeUsuarioPPAI.BusinessLayer
{
    class DirectorConstruccionInformeProductosMasPedidos
    {
        private IConstructorInforme _constructor;

        public DirectorConstruccionInformeProductosMasPedidos(IConstructorInforme constructor)
        {
            this._constructor = constructor;
        }

        public void Contruir()
    }
}
