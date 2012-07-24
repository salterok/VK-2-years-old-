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
        
        public class Video : VKAPIBranch {
            
            private const string API_BRANCH = "video.{0}";
            
            /// <summary>Создает объект класса <typeparamref name="Video"/>.</summary>
            public Video(bool needXml) : 
                    base(needXml) {
                API_URI_BASE_TEMPLATE = String.Format(API_URI_BASE, API_BRANCH);
            }
            
            #region video.get
            /// <summary>Возвращает информацию о видеозаписях.</summary>
            /// <param name="videos">перечисленные через запятую идентификаторы – идущие через знак подчеркивания id пользователей, которым принадлежат видеозаписи, и id самих видеозаписей</param>
            /// <param name="uid">id пользователя, видеозаписи которого нужно вернуть</param>
            /// <param name="gid">id группы, видеозаписи которой нужно вернуть</param>
            /// <param name="aid">id альбома видеозаписи из которого нужно вернуть</param>
            /// <param name="width">требуемая ширина изображений видеозаписей в пикселах</param>
            /// <param name="count">количество возвращаемых видеозаписей (максимум 200)</param>
            /// <param name="offset">смещение относительно первой найденной видеозаписи для выборки определенного подмножества</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private string get(string videos, System.Int64? uid, System.Int64? gid, System.Int64? aid, string width, System.Int32? count, System.Int32? offset) {
                manager.AddValueByName("@videos", videos);
                manager.AddValueByName("@uid", uid);
                manager.AddValueByName("@gid", gid);
                manager.AddValueByName("@aid", aid);
                manager.AddValueByName("@width", width);
                manager.AddValueByName("@count", count);
                manager.AddValueByName("@offset", offset);
                return GetResponse("get");
            }
            #endregion
            
            #region video.edit
            /// <summary>Редактирует данные видеозаписи на странице пользователя.</summary>
            /// <param name="vid">id видеозаписи</param>
            /// <param name="oid">id владельца видеозаписи</param>
            /// <param name="name">название видеозаписи</param>
            /// <param name="desc">описание видеозаписи</param>
            /// <param name="privacy_view">приватность на просмотр видео в соответствии с форматом приватности</param>
            /// <param name="privacy_comment">приватность на комментирование видео в соответствии с форматом приватности</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private string edit(string vid, System.Int64? oid, string name, string desc, string privacy_view, string privacy_comment) {
                manager.AddValueByName("@vid", vid);
                manager.AddValueByName("@oid", oid);
                manager.AddValueByName("@name", name);
                manager.AddValueByName("@desc", desc);
                manager.AddValueByName("@privacy_view", privacy_view);
                manager.AddValueByName("@privacy_comment", privacy_comment);
                return GetResponse("edit");
            }
            #endregion
            
            #region video.add
            /// <summary>Копирует видеозапись на страницу пользователя.</summary>
            /// <param name="vid">id видеозаписи</param>
            /// <param name="oid">id владельца видеозаписи</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private string add(string vid, System.Int64? oid) {
                manager.AddValueByName("@vid", vid);
                manager.AddValueByName("@oid", oid);
                return GetResponse("add");
            }
            #endregion
            
            #region video.delete
            /// <summary>Удаляет видеозапись со страницы пользователя.</summary>
            /// <param name="vid">id видеозаписи</param>
            /// <param name="oid">id владельца видеозаписи</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private string delete(string vid, System.Int64? oid) {
                manager.AddValueByName("@vid", vid);
                manager.AddValueByName("@oid", oid);
                return GetResponse("delete");
            }
            #endregion
            
            #region video.search
            /// <summary>Возвращает список видеозаписей в соответствии с заданным критерием поиска.</summary>
            /// <param name="q">строка поискового запроса</param>
            /// <param name="sort">Вид сортировки</param>
            /// <param name="hd">Если не равен нулю, то поиск производится только по видеозаписям высокого качества</param>
            /// <param name="count">количество возвращаемых видеозаписей (максимум 200)</param>
            /// <param name="offset">смещение относительно первой найденной видеозаписи для выборки определенного подмножества</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private string search(string q, SortOrder sort, string hd, System.Int32? count, System.Int32? offset) {
                manager.AddValueByName("@q", q);
                manager.AddValueByName("@sort", sort);
                manager.AddValueByName("@hd", hd);
                manager.AddValueByName("@count", count);
                manager.AddValueByName("@offset", offset);
                return GetResponse("search");
            }
            #endregion
            
            #region video.getUserVideos
            /// <summary>Возвращает список видеозаписей, на которых отмечен пользователь.</summary>
            /// <param name="uid">идентификатор пользователя (по умолчанию - текущий пользователь)</param>
            /// <param name="offset">смещение, необходимое для выборки определенного подмножества видеозаписей</param>
            /// <param name="count">количество видеозаписей, которое необходимо получить (но не более 100)</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private string getUserVideos(System.Int64? uid, System.Int32? offset, System.Int32? count) {
                manager.AddValueByName("@uid", uid);
                manager.AddValueByName("@offset", offset);
                manager.AddValueByName("@count", count);
                return GetResponse("getUserVideos");
            }
            #endregion
            
            #region video.getComments
            /// <summary>Возвращает список комментариев к видеозаписи.</summary>
            /// <param name="vid">идентификатор видеозаписи</param>
            /// <param name="owner_id">идентификатор пользователя (по умолчанию - текущий пользователь)</param>
            /// <param name="offset">смещение, необходимое для выборки определенного подмножества комментариев</param>
            /// <param name="count">количество комментариев, которое необходимо получить (но не более 100)</param>
            /// <param name="sort">порядок сортировки комментариев (asc - от старых к новым, desc - от новых к старым) </param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private string getComments(string vid, System.Int64? owner_id, System.Int32? offset, System.Int32? count, SortOrder sort) {
                manager.AddValueByName("@vid", vid);
                manager.AddValueByName("@owner_id", owner_id);
                manager.AddValueByName("@offset", offset);
                manager.AddValueByName("@count", count);
                manager.AddValueByName("@sort", sort);
                return GetResponse("getComments");
            }
            #endregion
            
            #region video.createComment
            /// <summary>Cоздает новый комментарий к видеозаписи.</summary>
            /// <param name="vid">идентификатор видеозаписи</param>
            /// <param name="owner_id">идентификатор пользователя (по умолчанию - текущий пользователь)</param>
            /// <param name="message">текст комментария (минимальная длина - 2 символа)</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private string createComment(string vid, System.Int64? owner_id, string message) {
                manager.AddValueByName("@vid", vid);
                manager.AddValueByName("@owner_id", owner_id);
                manager.AddValueByName("@message", message);
                return GetResponse("createComment");
            }
            #endregion
            
            #region video.editComment
            /// <summary>Изменяет текст комментария к видеозаписи.</summary>
            /// <param name="owner_id">идентификатор пользователя (по умолчанию - текущий пользователь)</param>
            /// <param name="сid">идентификатор комментария</param>
            /// <param name="message">текст комментария (минимальная длина - 2 символа)</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private string editComment(System.Int64? owner_id, string сid, string message) {
                manager.AddValueByName("@owner_id", owner_id);
                manager.AddValueByName("@сid", сid);
                manager.AddValueByName("@message", message);
                return GetResponse("editComment");
            }
            #endregion
            
            #region video.deleteComment
            /// <summary>Удаляет комментарий к видеозаписи.</summary>
            /// <param name="owner_id">идентификатор пользователя (по-умолчанию - текущий пользователь)</param>
            /// <param name="cid">идентификатор комментария</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private string deleteComment(System.Int64? owner_id, string cid) {
                manager.AddValueByName("@owner_id", owner_id);
                manager.AddValueByName("@cid", cid);
                return GetResponse("deleteComment");
            }
            #endregion
            
            #region video.getTags
            /// <summary>Возвращает список отметок на видеозаписи.</summary>
            /// <param name="owner_id">идентификатор пользователя (по умолчанию - текущий пользователь)</param>
            /// <param name="vid">идентификатор видеозаписи</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private string getTags(System.Int64? owner_id, string vid) {
                manager.AddValueByName("@owner_id", owner_id);
                manager.AddValueByName("@vid", vid);
                return GetResponse("getTags");
            }
            #endregion
            
            #region video.putTag
            /// <summary>Добавляет отметку на видеозапись.</summary>
            /// <param name="owner_id">идентификатор владельца видеозаписи (по умолчанию - текущий пользователь)</param>
            /// <param name="vid">идентификатор видеозаписи</param>
            /// <param name="uid">идентификатор пользователя, которого нужно отметить на видеозаписи</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private string putTag(System.Int64? owner_id, string vid, System.Int64? uid) {
                manager.AddValueByName("@owner_id", owner_id);
                manager.AddValueByName("@vid", vid);
                manager.AddValueByName("@uid", uid);
                return GetResponse("putTag");
            }
            #endregion
            
            #region video.removeTag
            /// <summary>Удаляет отметку с видеозаписи.</summary>
            /// <param name="owner_id">идентификатор владельца видеозаписи (по умолчанию - текущий пользователь)</param>
            /// <param name="vid">идентификатор видеозаписи</param>
            /// <param name="tag_id">идентификатор отметки, которую нужно удалить</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private string removeTag(System.Int64? owner_id, string vid, string tag_id) {
                manager.AddValueByName("@owner_id", owner_id);
                manager.AddValueByName("@vid", vid);
                manager.AddValueByName("@tag_id", tag_id);
                return GetResponse("removeTag");
            }
            #endregion
            
            #region video.save
            /// <summary>Возвращает адрес сервера (необходимый для</summary>
            /// <param name="name">название видеофайла</param>
            /// <param name="description">описание видеофайла</param>
            /// <param name="gid">Группа, в которую будет сохранён видеофайл</param>
            /// <param name="privacy_view">приватность на просмотр видео в соответствии с форматом приватности</param>
            /// <param name="privacy_comment">приватность на комментирование видео в соответствии с форматом приватности</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private string save(string name, string description, System.Int64? gid, string privacy_view, string privacy_comment) {
                manager.AddValueByName("@name", name);
                manager.AddValueByName("@description", description);
                manager.AddValueByName("@gid", gid);
                manager.AddValueByName("@privacy_view", privacy_view);
                manager.AddValueByName("@privacy_comment", privacy_comment);
                return GetResponse("save");
            }
            #endregion
        }
    }
}
