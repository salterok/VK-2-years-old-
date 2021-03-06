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
        
        public class Photos : VKAPIBranch {
            
            private const string API_BRANCH = "photos.{0}";
            
            /// <summary>Создает объект класса <typeparamref name="Photos"/>.</summary>
            public Photos(bool needXml) : 
                    base(needXml) {
                API_URI_BASE_TEMPLATE = String.Format(API_URI_BASE, API_BRANCH);
            }
            
            #region photos.getAlbums
            /// <summary>Возвращает список альбомов пользователя.</summary>
            /// <param name="uid">ID пользователя, которому принадлежат альбомы</param>
            /// <param name="gid">ID группы, которой принадлежат альбомы</param>
            /// <param name="aids">перечисленные через запятую ID альбомов</param>
            /// <param name="need_covers">1 - будет возвращено дополнительное поле thumb_src</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private VKResponseBase getAlbums(System.Int64? uid, System.Int64? gid, string aids, string need_covers) {
                manager.AddValueByName("@uid", uid);
                manager.AddValueByName("@gid", gid);
                manager.AddValueByName("@aids", aids);
                manager.AddValueByName("@need_covers", need_covers);
                return new VKResponseBase(GetResponse("getAlbums"), IsXMLResponse);
            }
            #endregion
            
            #region photos.get
            /// <summary></summary>
            /// <param name="uid">ID пользователя, которому принадлежит альбом с фотографиями</param>
            /// <param name="gid">ID группы, которой принадлежит альбом с фотографиями</param>
            /// <param name="aid">ID альбома с фотографиями</param>
            /// <param name="pids">перечисленные через запятую ID фотографий</param>
            /// <param name="extended">1 - будут возвращены дополнительные поле likes, comments, tags</param>
            /// <param name="limit">количество фотографий, которое нужно вернуть</param>
            /// <param name="offset">смещение, необходимое для выборки определенного подмножества фотографий</param>
            /// <param name="feed">Unixtime, который может быть получен методом newsfeed</param>
            /// <param name="feed_type">Тип новости получаемый в поле type метода newsfeed</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private VKResponseBase get(System.Int64? uid, System.Int64? gid, System.Int64? aid, string pids, System.Boolean? extended, string limit, System.Int32? offset, string feed, string feed_type) {
                manager.AddValueByName("@uid", uid);
                manager.AddValueByName("@gid", gid);
                manager.AddValueByName("@aid", aid);
                manager.AddValueByName("@pids", pids);
                manager.AddValueByName("@extended", extended);
                manager.AddValueByName("@limit", limit);
                manager.AddValueByName("@offset", offset);
                manager.AddValueByName("@feed", feed);
                manager.AddValueByName("@feed_type", feed_type);
                return new VKResponseBase(GetResponse("get"), IsXMLResponse);
            }
            #endregion
            
            #region photos.getProfile
            /// <summary>Возвращает список фотографий со страницы пользователя.</summary>
            /// <param name="uid">ID пользователя, которому принадлежит альбом с фотографиями</param>
            /// <param name="extended">1 - будет возвращено дополнительное поле likes</param>
            /// <param name="limit">количество фотографий, которое нужно вернуть</param>
            /// <param name="offset">смещение, необходимое для выборки определенного подмножества фотографий</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private VKResponseBase getProfile(System.Int64? uid, System.Boolean? extended, string limit, System.Int32? offset) {
                manager.AddValueByName("@uid", uid);
                manager.AddValueByName("@extended", extended);
                manager.AddValueByName("@limit", limit);
                manager.AddValueByName("@offset", offset);
                return new VKResponseBase(GetResponse("getProfile"), IsXMLResponse);
            }
            #endregion
            
            #region photos.getAll
            /// <summary>Возвращает все фотографии пользователя или группы в антихронологическом порядке.</summary>
            /// <param name="owner_id">идентификатор пользователя (по умолчанию - текущий пользователь)</param>
            /// <param name="no_service_albums">0 - вернуть все фотографии, включая находящиеся в сервисных альбомах, таких как &quot;Фотографии на моей стене&quot;</param>
            /// <param name="offset">смещение, необходимое для выборки определенного подмножества фотографий</param>
            /// <param name="count">количество фотографий, которое необходимо получить (но не более 100)</param>
            /// <param name="extended">1 - будет возвращено дополнительное поле likes</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private VKResponseBase getAll(System.Int64? owner_id, string no_service_albums, System.Int32? offset, System.Int32? count, System.Boolean? extended) {
                manager.AddValueByName("@owner_id", owner_id);
                manager.AddValueByName("@no_service_albums", no_service_albums);
                manager.AddValueByName("@offset", offset);
                manager.AddValueByName("@count", count);
                manager.AddValueByName("@extended", extended);
                return new VKResponseBase(GetResponse("getAll"), IsXMLResponse);
            }
            #endregion
            
            #region photos.getById
            /// <summary></summary>
            /// <param name="photos">перечисленные через запятую идентификаторы, которые представляют собой идущие через знак подчеркивания id пользователей, разместивших фотографии, и id самих фотографий</param>
            /// <param name="extended">1 - будут возвращены дополнительные поле likes, comments, tags</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private VKResponseBase getById(string photos, System.Boolean? extended) {
                manager.AddValueByName("@photos", photos);
                manager.AddValueByName("@extended", extended);
                return new VKResponseBase(GetResponse("getById"), IsXMLResponse);
            }
            #endregion
            
            #region photos.createAlbum
            /// <summary>Создает пустой альбом для фотографий.</summary>
            /// <param name="title">название альбома</param>
            /// <param name="privacy">уровень доступа к альбому</param>
            /// <param name="comment_privacy">уровень доступа к комментированию альбома</param>
            /// <param name="description">текст описания альбома</param>
            /// <param name="gid">идентификатор группы, в которой создаётся альбом</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private VKResponseBase createAlbum(string title, string privacy, string comment_privacy, string description, System.Int64? gid) {
                manager.AddValueByName("@title", title);
                manager.AddValueByName("@privacy", privacy);
                manager.AddValueByName("@comment_privacy", comment_privacy);
                manager.AddValueByName("@description", description);
                manager.AddValueByName("@gid", gid);
                return new VKResponseBase(GetResponse("createAlbum"), IsXMLResponse);
            }
            #endregion
            
            #region photos.editAlbum
            /// <summary>Редактирует данные альбома для фотографий пользователя.</summary>
            /// <param name="aid">идентификатор редактируемого альбома</param>
            /// <param name="title">новое название альбома</param>
            /// <param name="privacy">новый уровень доступа к альбому</param>
            /// <param name="comment_privacy">новый уровень доступа к комментированию альбома</param>
            /// <param name="description">новый текст описания альбома</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private VKResponseBase editAlbum(System.Int64? aid, string title, string privacy, string comment_privacy, string description) {
                manager.AddValueByName("@aid", aid);
                manager.AddValueByName("@title", title);
                manager.AddValueByName("@privacy", privacy);
                manager.AddValueByName("@comment_privacy", comment_privacy);
                manager.AddValueByName("@description", description);
                return new VKResponseBase(GetResponse("editAlbum"), IsXMLResponse);
            }
            #endregion
            
            #region photos.edit
            /// <summary>Изменяет описание у выбранной фотографии.</summary>
            /// <param name="owner_id">идентификатор пользователя (по умолчанию - текущий пользователь)</param>
            /// <param name="pid">ID фотографии, у которой необходимо изменить описание</param>
            /// <param name="caption">новый текст описания к фотографии</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private VKResponseBase edit(System.Int64? owner_id, System.Int64? pid, string caption) {
                manager.AddValueByName("@owner_id", owner_id);
                manager.AddValueByName("@pid", pid);
                manager.AddValueByName("@caption", caption);
                return new VKResponseBase(GetResponse("edit"), IsXMLResponse);
            }
            #endregion
            
            #region photos.move
            /// <summary>Переносит фотографию из одного альбома в другой.</summary>
            /// <param name="pid">id переносимой фотографии</param>
            /// <param name="target_aid">id альбома, куда переносится фотография</param>
            /// <param name="oid">id владельца переносимой фотографии, по умолчанию id текущего пользователя</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private VKResponseBase move(System.Int64? pid, string target_aid, System.Int64? oid) {
                manager.AddValueByName("@pid", pid);
                manager.AddValueByName("@target_aid", target_aid);
                manager.AddValueByName("@oid", oid);
                return new VKResponseBase(GetResponse("move"), IsXMLResponse);
            }
            #endregion
            
            #region photos.makeCover
            /// <summary>Делает фотографию обложкой альбома.</summary>
            /// <param name="pid">id фотографии, которая должна стать обложкой альбома</param>
            /// <param name="aid">id альбома</param>
            /// <param name="oid">id владельца альбома, по умолчанию id текущего пользователя</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private VKResponseBase makeCover(System.Int64? pid, System.Int64? aid, System.Int64? oid) {
                manager.AddValueByName("@pid", pid);
                manager.AddValueByName("@aid", aid);
                manager.AddValueByName("@oid", oid);
                return new VKResponseBase(GetResponse("makeCover"), IsXMLResponse);
            }
            #endregion
            
            #region photos.reorderAlbums
            /// <summary>Меняет порядок альбома в списке альбомов пользователя.</summary>
            /// <param name="aid">id альбома, порядок которого нужно изменить</param>
            /// <param name="before">id альбома, перед которым следует поместить альбом</param>
            /// <param name="after">id альбома, после которого следует поместить альбом</param>
            /// <param name="oid">id владельца альбома, по умолчанию id текущего пользователя</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private VKResponseBase reorderAlbums(System.Int64? aid, System.Int64? before, System.Int64? after, System.Int64? oid) {
                manager.AddValueByName("@aid", aid);
                manager.AddValueByName("@before", before);
                manager.AddValueByName("@after", after);
                manager.AddValueByName("@oid", oid);
                return new VKResponseBase(GetResponse("reorderAlbums"), IsXMLResponse);
            }
            #endregion
            
            #region photos.reorderPhotos
            /// <summary>Меняет порядок фотографии в списке фотографий альбома пользователя.</summary>
            /// <param name="pid">id фотографии, порядок которой нужно изменить</param>
            /// <param name="before">id фотографии, перед которой следует поместить фотографию</param>
            /// <param name="after">id фотографии, после которой следует поместить фотографию</param>
            /// <param name="oid">id владельца фотографии, по умолчанию id текущего пользователя</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private VKResponseBase reorderPhotos(System.Int64? pid, System.Int64? before, System.Int64? after, System.Int64? oid) {
                manager.AddValueByName("@pid", pid);
                manager.AddValueByName("@before", before);
                manager.AddValueByName("@after", after);
                manager.AddValueByName("@oid", oid);
                return new VKResponseBase(GetResponse("reorderPhotos"), IsXMLResponse);
            }
            #endregion
            
            #region photos.getUploadServer
            /// <summary>Возвращает адрес сервера для</summary>
            /// <param name="aid">ID альбома, в который необходимо загрузить фотографии</param>
            /// <param name="gid">ID группы, при загрузке фотографии в группу</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private VKResponseBase getUploadServer(System.Int64? aid, System.Int64? gid) {
                manager.AddValueByName("@aid", aid);
                manager.AddValueByName("@gid", gid);
                return new VKResponseBase(GetResponse("getUploadServer"), IsXMLResponse);
            }
            #endregion
            
            #region photos.save
            /// <summary>Сохраняет фотографии после успешной</summary>
            /// <param name="aid">ID альбома, в который необходимо загрузить фотографии</param>
            /// <param name="server">параметр, возвращаемый в результате загрузки фотографий на сервер</param>
            /// <param name="photos_list">параметр, возвращаемый в результате загрузки фотографий на сервер</param>
            /// <param name="hash">параметр, возвращаемый в результате загрузки фотографий на сервер</param>
            /// <param name="gid">ID группы, при загрузке фотографии в группу</param>
            /// <param name="caption">Описание фотографии</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private VKResponseBase save(System.Int64? aid, string server, string photos_list, string hash, System.Int64? gid, string caption) {
                manager.AddValueByName("@aid", aid);
                manager.AddValueByName("@server", server);
                manager.AddValueByName("@photos_list", photos_list);
                manager.AddValueByName("@hash", hash);
                manager.AddValueByName("@gid", gid);
                manager.AddValueByName("@caption", caption);
                return new VKResponseBase(GetResponse("save"), IsXMLResponse);
            }
            #endregion
            
            #region photos.getProfileUploadServer
            /// <summary>Возвращает адрес сервера для загрузки фотографии на страницу пользователя. После удачной загрузки Вы можете воспользоваться методом</summary>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private VKResponseBase getProfileUploadServer() {
                return new VKResponseBase(GetResponse("getProfileUploadServer"), IsXMLResponse);
            }
            #endregion
            
            #region photos.saveProfilePhoto
            /// <summary>Сохраняет фотографию пользователя после успешной</summary>
            /// <param name="server">параметр, возвращаемый в результате загрузки фотографий на сервер</param>
            /// <param name="photo">параметр, возвращаемый в результате загрузки фотографий на сервер</param>
            /// <param name="hash">параметр, возвращаемый в результате загрузки фотографий на сервер</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private VKResponseBase saveProfilePhoto(string server, string photo, string hash) {
                manager.AddValueByName("@server", server);
                manager.AddValueByName("@photo", photo);
                manager.AddValueByName("@hash", hash);
                return new VKResponseBase(GetResponse("saveProfilePhoto"), IsXMLResponse);
            }
            #endregion
            
            #region photos.getWallUploadServer
            /// <summary>Возвращает адрес сервера для</summary>
            /// <param name="uid">ID пользователя, при загрузке фотографии на стену другому пользователю</param>
            /// <param name="gid">ID группы, при загрузке фотографии на стену группы</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private VKResponseBase getWallUploadServer(System.Int64? uid, System.Int64? gid) {
                manager.AddValueByName("@uid", uid);
                manager.AddValueByName("@gid", gid);
                return new VKResponseBase(GetResponse("getWallUploadServer"), IsXMLResponse);
            }
            #endregion
            
            #region photos.saveWallPhoto
            /// <summary>Сохраняет фотографии после успешной</summary>
            /// <param name="server">параметр, возвращаемый в результате загрузки фотографий на сервер</param>
            /// <param name="photo">параметр, возвращаемый в результате загрузки фотографий на сервер</param>
            /// <param name="hash">параметр, возвращаемый в результате загрузки фотографий на сервер</param>
            /// <param name="uid">ID пользователя, при загрузке фотографии на стену другому пользователю</param>
            /// <param name="gid">ID группы, при загрузке фотографии на стену группы</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private VKResponseBase saveWallPhoto(string server, string photo, string hash, System.Int64? uid, System.Int64? gid) {
                manager.AddValueByName("@server", server);
                manager.AddValueByName("@photo", photo);
                manager.AddValueByName("@hash", hash);
                manager.AddValueByName("@uid", uid);
                manager.AddValueByName("@gid", gid);
                return new VKResponseBase(GetResponse("saveWallPhoto"), IsXMLResponse);
            }
            #endregion
            
            #region photos.getComments
            /// <summary>Возвращает список комментариев к фотографии.</summary>
            /// <param name="pid">идентификатор фотографии</param>
            /// <param name="owner_id">идентификатор пользователя (по умолчанию - текущий пользователь)</param>
            /// <param name="offset">смещение, необходимое для выборки определенного подмножества комментариев</param>
            /// <param name="count">количество комментариев, которое необходимо получить (но не более 100)</param>
            /// <param name="sort">порядок сортировки комментариев (asc - от старых к новым, desc - от новых к старым) </param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private VKResponseBase getComments(System.Int64? pid, System.Int64? owner_id, System.Int32? offset, System.Int32? count, SortOrder sort) {
                manager.AddValueByName("@pid", pid);
                manager.AddValueByName("@owner_id", owner_id);
                manager.AddValueByName("@offset", offset);
                manager.AddValueByName("@count", count);
                manager.AddValueByName("@sort", sort);
                return new VKResponseBase(GetResponse("getComments"), IsXMLResponse);
            }
            #endregion
            
            #region photos.getAllComments
            /// <summary>Возвращает отсортированный в антихронологическом порядке список всех комментариев к конкретному альбому или ко всем альбомам пользователя.</summary>
            /// <param name="owner_id">идентификатор пользователя</param>
            /// <param name="aid">идентификатор альбома</param>
            /// <param name="offset">смещение, необходимое для выборки определенного подмножества комментариев</param>
            /// <param name="count">количество комментариев, которое необходимо получить</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private VKResponseBase getAllComments(System.Int64? owner_id, System.Int64? aid, System.Int32? offset, System.Int32? count) {
                manager.AddValueByName("@owner_id", owner_id);
                manager.AddValueByName("@aid", aid);
                manager.AddValueByName("@offset", offset);
                manager.AddValueByName("@count", count);
                return new VKResponseBase(GetResponse("getAllComments"), IsXMLResponse);
            }
            #endregion
            
            #region photos.createComment
            /// <summary>Cоздает новый комментарий к фотографии.</summary>
            /// <param name="pid">идентификатор фотографии</param>
            /// <param name="owner_id">идентификатор пользователя (по умолчанию - текущий пользователь)</param>
            /// <param name="message">текст комментария (минимальная длина - 2 символа)</param>
            /// <param name="reply_to_cid">идентификатор комментария, ответом на который является добавляемый комментарий</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private VKResponseBase createComment(System.Int64? pid, System.Int64? owner_id, string message, System.Int64? reply_to_cid) {
                manager.AddValueByName("@pid", pid);
                manager.AddValueByName("@owner_id", owner_id);
                manager.AddValueByName("@message", message);
                manager.AddValueByName("@reply_to_cid", reply_to_cid);
                return new VKResponseBase(GetResponse("createComment"), IsXMLResponse);
            }
            #endregion
            
            #region photos.editComment
            /// <summary>Изменяет текст комментария к фотографии.</summary>
            /// <param name="pid">идентификатор фотографии</param>
            /// <param name="owner_id">идентификатор пользователя (по умолчанию - текущий пользователь)</param>
            /// <param name="сid">идентификатор комментария</param>
            /// <param name="message">текст комментария (минимальная длина - 2 символа)</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private VKResponseBase editComment(System.Int64? pid, System.Int64? owner_id, string сid, string message) {
                manager.AddValueByName("@pid", pid);
                manager.AddValueByName("@owner_id", owner_id);
                manager.AddValueByName("@сid", сid);
                manager.AddValueByName("@message", message);
                return new VKResponseBase(GetResponse("editComment"), IsXMLResponse);
            }
            #endregion
            
            #region photos.deleteComment
            /// <summary>Удаляет комментарий к фотографии.</summary>
            /// <param name="pid">идентификатор фотографии</param>
            /// <param name="owner_id">идентификатор пользователя (по умолчанию - текущий пользователь)</param>
            /// <param name="cid">идентификатор комментария</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private VKResponseBase deleteComment(System.Int64? pid, System.Int64? owner_id, System.Int64? cid) {
                manager.AddValueByName("@pid", pid);
                manager.AddValueByName("@owner_id", owner_id);
                manager.AddValueByName("@cid", cid);
                return new VKResponseBase(GetResponse("deleteComment"), IsXMLResponse);
            }
            #endregion
            
            #region photos.restoreComment
            /// <summary>Восстанавливает удаленный комментарий к фотографии.</summary>
            /// <param name="pid">идентификатор фотографии</param>
            /// <param name="owner_id">идентификатор пользователя (по умолчанию - текущий пользователь)</param>
            /// <param name="cid">идентификатор комментария</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private VKResponseBase restoreComment(System.Int64? pid, System.Int64? owner_id, System.Int64? cid) {
                manager.AddValueByName("@pid", pid);
                manager.AddValueByName("@owner_id", owner_id);
                manager.AddValueByName("@cid", cid);
                return new VKResponseBase(GetResponse("restoreComment"), IsXMLResponse);
            }
            #endregion
            
            #region photos.getUserPhotos
            /// <summary>Возвращает список фотографий, на которых отмечен пользователь.</summary>
            /// <param name="uid">идентификатор пользователя (по умолчанию - текущий пользователь)</param>
            /// <param name="offset">смещение, необходимое для выборки определенного подмножества фотографий</param>
            /// <param name="count">количество фотографий, которое необходимо получить (но не более 100)</param>
            /// <param name="sort">сортировка результатов (0 - по дате добавления отметки в порядке убывания, 1 - по дате добавления отметки в порядке возрастания)</param>
            /// <param name="extended">1 - будет возвращено дополнительное поле likes</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private VKResponseBase getUserPhotos(System.Int64? uid, System.Int32? offset, System.Int32? count, SortOrder sort, System.Boolean? extended) {
                manager.AddValueByName("@uid", uid);
                manager.AddValueByName("@offset", offset);
                manager.AddValueByName("@count", count);
                manager.AddValueByName("@sort", sort);
                manager.AddValueByName("@extended", extended);
                return new VKResponseBase(GetResponse("getUserPhotos"), IsXMLResponse);
            }
            #endregion
            
            #region photos.getTags
            /// <summary>Возвращает список отметок на фотографии.</summary>
            /// <param name="owner_id">идентификатор пользователя (по умолчанию - текущий пользователь)</param>
            /// <param name="pid">идентификатор фотографии</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private VKResponseBase getTags(System.Int64? owner_id, System.Int64? pid) {
                manager.AddValueByName("@owner_id", owner_id);
                manager.AddValueByName("@pid", pid);
                return new VKResponseBase(GetResponse("getTags"), IsXMLResponse);
            }
            #endregion
            
            #region photos.putTag
            /// <summary>Добавляет отметку на фотографию.</summary>
            /// <param name="owner_id">идентификатор владельца фотографии (по умолчанию - текущий пользователь)</param>
            /// <param name="pid">идентификатор фотографии</param>
            /// <param name="uid">идентификатор пользователя, которого нужно отметить на фотографии</param>
            /// <param name="x">координата верхнего-левого угла отметки в % от ширины фотографии</param>
            /// <param name="y">координата верхнего-левого угла отметки в % от высоты фотографии</param>
            /// <param name="x2">координата правого-нижнего угла отметки в % от ширины фотографии</param>
            /// <param name="y2">координата правого-нижнего угла отметки  в % от высоты фотографии</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private VKResponseBase putTag(System.Int64? owner_id, System.Int64? pid, System.Int64? uid, string x, string y, string x2, string y2) {
                manager.AddValueByName("@owner_id", owner_id);
                manager.AddValueByName("@pid", pid);
                manager.AddValueByName("@uid", uid);
                manager.AddValueByName("@x", x);
                manager.AddValueByName("@y", y);
                manager.AddValueByName("@x2", x2);
                manager.AddValueByName("@y2", y2);
                return new VKResponseBase(GetResponse("putTag"), IsXMLResponse);
            }
            #endregion
            
            #region photos.removeTag
            /// <summary>Удаляет отметку с фотографии.</summary>
            /// <param name="owner_id">идентификатор владельца фотографии (по умолчанию - текущий пользователь)</param>
            /// <param name="pid">идентификатор фотографии</param>
            /// <param name="tag_id">идентификатор отметки, которую нужно удалить</param>
            /// <returns>Ответ сервера в XML или JSON формате.</returns>
            private VKResponseBase removeTag(System.Int64? owner_id, System.Int64? pid, string tag_id) {
                manager.AddValueByName("@owner_id", owner_id);
                manager.AddValueByName("@pid", pid);
                manager.AddValueByName("@tag_id", tag_id);
                return new VKResponseBase(GetResponse("removeTag"), IsXMLResponse);
            }
            #endregion
        }
    }
}
