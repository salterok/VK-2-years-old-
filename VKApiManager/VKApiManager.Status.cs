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
        
        public class Status : VKAPIBranch {
            
            private const string API_BRANCH = "status.{0}";
            
            /// <summary>Создает объект класса <typeparamref name="Status"/>.</summary>
            public Status(bool needXml) : 
                    base(needXml) {
                API_URI_BASE_TEMPLATE = String.Format(API_URI_BASE, API_BRANCH);
            }
            
            #region status.get
            /// <summary>Получает текст статуса пользователя.</summary>
            /// <param name="uid">идентификатор пользователя, статус которого необходимо получить</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private string get(System.Int64? uid) {
                manager.AddValueByName("@uid", uid);
                return GetResponse("get");
            }
            #endregion
            
            #region status.set
            /// <summary>Устанавливает новый статус текущему пользователю.</summary>
            /// <param name="text">текст статуса, который необходимо установить текущему пользователю</param>
            /// <param name="audio">текущая аудиозапись, которую необходимо транслировать в статус, задается в формате oid_aid (идентификатор владельца и идентификатор аудиозаписи, разделенные знаком подчеркивания)</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private string set(string text, string audio) {
                manager.AddValueByName("@text", text);
                manager.AddValueByName("@audio", audio);
                return GetResponse("set");
            }
            #endregion
        }
    }
}
