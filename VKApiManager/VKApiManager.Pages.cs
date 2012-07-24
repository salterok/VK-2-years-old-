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
        
        public class Pages : VKAPIBranch {
            
            private const string API_BRANCH = "pages.{0}";
            
            /// <summary>Создает объект класса <typeparamref name="Pages"/>.</summary>
            public Pages(bool needXml) : 
                    base(needXml) {
                API_URI_BASE_TEMPLATE = String.Format(API_URI_BASE, API_BRANCH);
            }
            
            #region pages.get
            /// <summary>Возвращает информацию о вики-странице.</summary>
            /// <param name="pid">id вики-страницы</param>
            /// <param name="title">название вики-страницы</param>
            /// <param name="gid">id группы, где создана страница</param>
            /// <param name="mid">id создателя вики-страницы, в случае если необходимо обратиться к одной из личных вики страниц пользователя</param>
            /// <param name="global">1 - требуется получить глобальную вики-страницу</param>
            /// <param name="need_html">определяет, требуется ли в ответе html-представление вики-страницы</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private string get(System.Int64? pid, string title, System.Int64? gid, System.Int64? mid, bool? global, bool? need_html) {
                manager.AddValueByName("@pid", pid);
                manager.AddValueByName("@title", title);
                manager.AddValueByName("@gid", gid);
                manager.AddValueByName("@mid", mid);
                manager.AddValueByName("@global", global);
                manager.AddValueByName("@need_html", need_html);
                return GetResponse("get");
            }
            #endregion
            
            #region pages.save
            /// <summary>Сохраняет текст вики-страницы.</summary>
            /// <param name="pid">id вики-страницы</param>
            /// <param name="gid">id группы, где создана страница</param>
            /// <param name="Text">новый текст страницы в вики-формате</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private string save(System.Int64? pid, System.Int64? gid, string Text) {
                manager.AddValueByName("@pid", pid);
                manager.AddValueByName("@gid", gid);
                manager.AddValueByName("@Text", Text);
                return GetResponse("save");
            }
            #endregion
            
            #region pages.saveAccess
            /// <summary>Сохраняет новые настройки доступа на чтение и редактирование вики-страницы.</summary>
            /// <param name="pid">id вики-страницы</param>
            /// <param name="gid">id группы, где создана страница</param>
            /// <param name="view">значение настройки доступа на чтение; описание значений Вы можете узнать странице, посвященной методу pages</param>
            /// <param name="edit">значение настройки доступа на редактирование; описание значений Вы можете узнать странице, посвященной методу pages</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private string saveAccess(System.Int64? pid, System.Int64? gid, string view, string edit) {
                manager.AddValueByName("@pid", pid);
                manager.AddValueByName("@gid", gid);
                manager.AddValueByName("@view", view);
                manager.AddValueByName("@edit", edit);
                return GetResponse("saveAccess");
            }
            #endregion
            
            #region pages.getVersion
            /// <summary>Возвращает текст одной из старых версий страницы.</summary>
            /// <param name="hid">id версии вики-страницы</param>
            /// <param name="gid">id группы, где создана страница</param>
            /// <param name="need_html">определяет, требуется ли в ответе html-представление версии вики-страницы</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private string getVersion(System.Int64? hid, System.Int64? gid, bool? need_html) {
                manager.AddValueByName("@hid", hid);
                manager.AddValueByName("@gid", gid);
                manager.AddValueByName("@need_html", need_html);
                return GetResponse("getVersion");
            }
            #endregion
            
            #region pages.getHistory
            /// <summary>Возвращает список всех старых версий вики-страницы.</summary>
            /// <param name="pid">id вики-страницы</param>
            /// <param name="gid">id группы, где создана страница</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private string getHistory(System.Int64? pid, System.Int64? gid) {
                manager.AddValueByName("@pid", pid);
                manager.AddValueByName("@gid", gid);
                return GetResponse("getHistory");
            }
            #endregion
            
            #region pages.getTitles
            /// <summary>Возвращает список вики-страниц в группе.</summary>
            /// <param name="gid">id группы, где создана страница</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private string getTitles(System.Int64? gid) {
                manager.AddValueByName("@gid", gid);
                return GetResponse("getTitles");
            }
            #endregion
        }
    }
}