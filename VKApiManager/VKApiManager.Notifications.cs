//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17626
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
        
        public class Notifications : VKAPIBranch {
            
            private const string API_BRANCH = "notifications.{0}";
            
            /// <summary>Создает объект класса <typeparamref name="Notifications"/>.</summary>
            public Notifications(bool needXml) : 
                    base(needXml) {
                API_URI_BASE_TEMPLATE = String.Format(API_URI_BASE, API_BRANCH);
            }
            
            #region notifications.get
            /// <summary>Возвращает список оповещений об ответах других пользователей на записи
            ///                    текущего пользователя</summary>
            /// <param name="filters">перечисленные через запятую типы оповещений, которые необходимо
            ///                            получить</param>
            /// <param name="start_time">время, в формате unixtime, начиная с которого следует получить
            ///                            оповещения для текущего пользователя</param>
            /// <param name="end_time">время, в формате unixtime, до которого следует получить
            ///                            оповещения для текущего пользователя</param>
            /// <param name="offset">смещение, начиная с которого следует вернуть список
            ///                            оповещений</param>
            /// <param name="count">указывает, какое максимальное число оповещений следует
            ///                            возвращать, но не более 100</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private VKResponseBase get(string filters, string start_time, string end_time, System.Int32? offset, System.Int32? count) {
                manager.AddValueByName("@filters", filters);
                manager.AddValueByName("@start_time", start_time);
                manager.AddValueByName("@end_time", end_time);
                manager.AddValueByName("@offset", offset);
                manager.AddValueByName("@count", count);
                return new VKResponseBase(GetResponse("get"), IsXMLResponse);
            }
            
            /// <summary>Возвращает список оповещений об ответах других пользователей на записи
            ///                    текущего пользователя</summary>
            /// <param name="filters">перечисленные через запятую типы оповещений, которые необходимо
            ///                            получить</param>
            /// <param name="start_time">время, в формате unixtime, начиная с которого следует получить
            ///                            оповещения для текущего пользователя</param>
            /// <param name="end_time">время, в формате unixtime, до которого следует получить
            ///                            оповещения для текущего пользователя</param>
            /// <param name="offset">смещение, начиная с которого следует вернуть список
            ///                            оповещений</param>
            /// <param name="count">указывает, какое максимальное число оповещений следует
            ///                            возвращать, но не более 100</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            public VKResponseBase Get(Filter? filters = null, DateTime? start_time = null, DateTime? end_time = null, int? offset = null, int? count = null) {
                return get(filters, start_time, end_time, offset, count);
            }
            #endregion
            
            #region notification.markAsViewed
            /// <summary>Сбрасывает счетчик непросмотренных оповещений об ответах других пользователей на записи текущего пользователя.</summary>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private VKResponseBase markAsViewed() {
                return new VKResponseBase(GetResponse("markAsViewed"), IsXMLResponse);
            }
            
            /// <summary>Сбрасывает счетчик непросмотренных оповещений об ответах других пользователей на записи текущего пользователя.</summary>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            public VKResponseBase MarkAsViewed() {
                return markAsViewed();
            }
            #endregion
        }
    }
}
