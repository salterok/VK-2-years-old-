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
        
        public class Fave : VKAPIBranch {
            
            private const string API_BRANCH = "fave.{0}";
            
            /// <summary>Создает объект класса <typeparamref name="Fave"/>.</summary>
            public Fave(bool needXml) : 
                    base(needXml) {
                API_URI_BASE_TEMPLATE = String.Format(API_URI_BASE, API_BRANCH);
            }
            
            #region fave.getPhotos
            /// <summary>Возвращает фотографии, на которых текущий пользователь поставил отметку &quot;Мне нравится&quot;.</summary>
            /// <param name="offset">смещение, необходимое для выборки определенного подмножества фотографий</param>
            /// <param name="count">количество фотографий, которое необходимо получить</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private string getPhotos(System.Int32? offset, System.Int32? count) {
                manager.AddValueByName("@offset", offset);
                manager.AddValueByName("@count", count);
                return GetResponse("getPhotos");
            }
            #endregion
            
            #region fave.getVideos
            /// <summary>Возвращает список видеозаписей, на которых текущий пользователь поставил отметку &quot;Мне нравится&quot;.</summary>
            /// <param name="count">количество возвращаемых видеозаписей</param>
            /// <param name="offset">смещение относительно первой найденной видеозаписи для выборки определенного подмножества</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private string getVideos(System.Int32? count, System.Int32? offset) {
                manager.AddValueByName("@count", count);
                manager.AddValueByName("@offset", offset);
                return GetResponse("getVideos");
            }
            #endregion
            
            #region fave.getPosts
            /// <summary>Возвращает записи, на которых текущий пользователь поставил отметку &quot;Мне нравится&quot;.</summary>
            /// <param name="offset">смещение, необходимое для выборки определенного подмножества сообщений</param>
            /// <param name="count">количество сообщений, которое необходимо получить (но не более 100)</param>
            /// <param name="extended">1 - будут возвращены три массива wall, profiles, и groups</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private string getPosts(System.Int32? offset, System.Int32? count, bool? extended) {
                manager.AddValueByName("@offset", offset);
                manager.AddValueByName("@count", count);
                manager.AddValueByName("@extended", extended);
                return GetResponse("getPosts");
            }
            #endregion
            
            #region fave.getUsers
            /// <summary>Возвращает список пользователей, добавленных текущим пользователем в закладки.</summary>
            /// <param name="fields">Список полей профилей пользователей, которые необходимо вернуть</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private string getUsers(ProfileFields? fields) {
                manager.AddValueByName("@fields", fields);
                return GetResponse("getUsers");
            }
            #endregion
            
            #region fave.getLinks
            /// <summary>Возвращает ссылки, добавленные в закладки текущим пользователем.</summary>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private string getLinks() {
                return GetResponse("getLinks");
            }
            #endregion
        }
    }
}
