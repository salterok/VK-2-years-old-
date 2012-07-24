//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VK {
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    
    public partial class VKApiManager {
        
        public class Execute : VKAPIBranch {
            
            private const string API_BRANCH = "execute.{0}";
            
            /// <summary>Создает объект класса <typeparamref name="Execute"/>.</summary>
            public Execute(bool needXml) : 
                    base(needXml) {
                API_URI_BASE_TEMPLATE = String.Format(API_URI_BASE, API_BRANCH);
            }
            
            #region execute
            /// <summary>Универсальный метод, который позволяет запускать последовательность других методов, сохраняя и фильтруя промежуточные результаты.</summary>
            /// <param name="code">код алгоритма в VKScript - формате, похожем на JavaSсript или ActionScript (предполагается совместимость с ECMAScript)</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private string execute(string code) {
                manager.AddValueByName("@code", code);
                return GetResponse("execute", true);
            }
            #endregion
        }
    }
}
