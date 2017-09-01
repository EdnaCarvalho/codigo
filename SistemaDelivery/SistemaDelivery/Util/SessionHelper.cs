using System;
using System.Web;

namespace SistemaDelivery.Util
{
    public enum SessionKeys { Empresa, Usuario}

    public static class SessionHelper
    {
        public static Object Get(SessionKeys chave)
        {
            String chaveString = Enum.GetName(typeof(SessionKeys),chave);
            return HttpContext.Current.Session[chaveString];
        }

        public static Object Set(SessionKeys chave,Object valor)
        {
            String chaveString = Enum.GetName(typeof(SessionKeys), chave);
            return HttpContext.Current.Session[chaveString] = valor;
        }
    }
}