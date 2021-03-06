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

		public class Messages : VKAPIBranch {

			private const string API_BRANCH = "messages.{0}";

			/// <summary>Создает объект класса <typeparamref name="Messages"/>.</summary>
			public Messages(bool needXml) :
				base(needXml) {
				API_URI_BASE_TEMPLATE = String.Format(API_URI_BASE, API_BRANCH);
			}

			#region messages.get
			/// <summary>Возвращает список входящих либо исходящих личных сообщений текущего пользователя.</summary>
			/// <param name="out">если этот параметр равен 1, сервер вернет исходящие сообщения</param>
			/// <param name="offset">смещение, необходимое для выборки определенного подмножества сообщений</param>
			/// <param name="count">количество сообщений, которое необходимо получить (но не более 100)</param>
			/// <param name="filters">фильтр возвращаемых сообщений: 1 - только непрочитанные; 2 - не из чата; 4 - сообщения от друзей</param>
			/// <param name="preview_length">Количество символов, по которому нужно обрезать сообщение</param>
			/// <param name="time_offset">Максимальное время, прошедшее с момента отправки сообщения до текущего момента в секундах</param>
			/// <returns>Ответ сервера в XML или JSON формате.</returns>
			private VKResponseBase get(System.Boolean? @out, System.Int32? offset, System.Int32? count, MessageFilter? filters, System.Int32? preview_length, System.Int32? time_offset) {
				manager.AddValueByName("@out", @out);
				manager.AddValueByName("@offset", offset);
				manager.AddValueByName("@count", count);
				manager.AddValueByName("@filters", filters);
				manager.AddValueByName("@preview_length", preview_length);
				manager.AddValueByName("@time_offset", time_offset);
				return new VKResponseBase(GetResponse("get"), IsXMLResponse);
			}

			/// <summary>Возвращает список входящих либо исходящих личных сообщений текущего пользователя.</summary>
			/// <param name="out">если этот параметр равен 1, сервер вернет исходящие сообщения</param>
			/// <param name="filters">фильтр возвращаемых сообщений: 1 - только непрочитанные; 2 - не из чата; 4 - сообщения от друзей</param>
			/// <param name="preview_length">Количество символов, по которому нужно обрезать сообщение</param>
			/// <param name="time_offset">Максимальное время, прошедшее с момента отправки сообщения до текущего момента в секундах</param>
			/// <param name="offset">смещение, необходимое для выборки определенного подмножества сообщений</param>
			/// <param name="count">количество сообщений, которое необходимо получить (но не более 100)</param>
			/// <returns>Ответ сервера в XML или JSON формате.</returns>
			public VKResponseBase Get(System.Boolean? @out, MessageFilter? filters = null, System.Int32? preview_length = null, System.Int32? time_offset = null, System.Int32? offset = null, System.Int32? count = null) {
				return get(@out, offset, count, filters, preview_length, time_offset);
			}
			#endregion

			#region messages.getById
			/// <summary>Возвращает сообщения по их ID.</summary>
			/// <param name="mid">ID сообщения, если необходимо получить одно сообщение</param>
			/// <param name="mids">ID сообщений, которые необходимо вернуть, разделенные запятыми (не более 100)</param>
			/// <param name="preview_length">Количество слов, по которому нужно обрезать сообщение</param>
			/// <returns>Ответ сервера в XML или JSON формате.</returns>
			private VKResponseBase getById(System.Int64? mid, IdList mids, System.Int32? preview_length) {
				manager.AddValueByName("@mid", mid);
				manager.AddValueByName("@mids", mids);
				manager.AddValueByName("@preview_length", preview_length);
				return new VKResponseBase(GetResponse("getById"), IsXMLResponse);
			}

			/// <summary>Возвращает сообщения по их ID.</summary>
			/// <param name="mid">ID сообщения, если необходимо получить одно сообщение</param>
			/// <param name="preview_length">Количество слов, по которому нужно обрезать сообщение</param>
			/// <returns>Ответ сервера в XML или JSON формате.</returns>
			public VKResponseBase GetById(System.Int64? mid, System.Int32? preview_length = null) {
				return getById(mid, null, preview_length);
			}

			/// <summary>Возвращает сообщения по их ID.</summary>
			/// <param name="mids">ID сообщений, которые необходимо вернуть, разделенные запятыми (не более 100)</param>
			/// <param name="preview_length">Количество слов, по которому нужно обрезать сообщение</param>
			/// <returns>Ответ сервера в XML или JSON формате.</returns>
			public VKResponseBase GetById(IdList mids, System.Int32? preview_length = null) {
				return getById(null, mids, preview_length);
			}
			#endregion

			#region messages.getDialogs
			/// <summary>Возвращает список диалогов текущего пользователя.</summary>
			/// <param name="uid">идентификатор пользователя, последнее сообщение в переписке с которым необходимо вернуть</param>
			/// <param name="chat_id">идентификатор беседы, последнее сообщение в которой необходимо вернуть</param>
			/// <param name="offset">смещение, необходимое для выборки определенного подмножества диалогов</param>
			/// <param name="count">количество диалогов, которое необходимо получить (но не более 200)</param>
			/// <param name="preview_length">Количество символов, по которому нужно обрезать сообщение</param>
			/// <returns>Ответ сервера в XML или JSON формате.</returns>
			private VKResponseBase getDialogs(System.Int64? uid, System.Int64? chat_id, System.Int32? offset, System.Int32? count, System.Int32? preview_length) {
				manager.AddValueByName("@uid", uid);
				manager.AddValueByName("@chat_id", chat_id);
				manager.AddValueByName("@offset", offset);
				manager.AddValueByName("@count", count);
				manager.AddValueByName("@preview_length", preview_length);
				return new VKResponseBase(GetResponse("getDialogs"), IsXMLResponse);
			}

			/// <summary>Возвращает список диалогов текущего пользователя.</summary>
			/// <param name="uid">идентификатор пользователя, последнее сообщение в переписке с которым необходимо вернуть</param>
			/// <param name="preview_length">Количество символов, по которому нужно обрезать сообщение</param>
			/// <param name="offset">смещение, необходимое для выборки определенного подмножества диалогов</param>
			/// <param name="count">количество диалогов, которое необходимо получить (но не более 200)</param>
			/// <returns>Ответ сервера в XML или JSON формате.</returns>
			public VKResponseBase GetDialogs(System.Int64? uid, System.Int32? preview_length = null, System.Int32? offset = null, System.Int32? count = null) {
				return getDialogs(uid, null, offset, count, preview_length);
			}

			/// <summary>Возвращает список диалогов текущего пользователя.</summary>
			/// <param name="chat_id">идентификатор беседы, последнее сообщение в которой необходимо вернуть</param>
			/// <param name="preview_length">Количество символов, по которому нужно обрезать сообщение</param>
			/// <param name="offset">смещение, необходимое для выборки определенного подмножества диалогов</param>
			/// <param name="count">количество диалогов, которое необходимо получить (но не более 200)</param>
			/// <returns>Ответ сервера в XML или JSON формате.</returns>
			public VKResponseBase GetDialogsChat(System.Int64? chat_id, System.Int32? preview_length = null, System.Int32? offset = null, System.Int32? count = null) {
				return getDialogs(null, chat_id, offset, count, preview_length);
			}
			#endregion

			#region messages.search
			/// <summary>Возвращает список найденных личных сообщений текущего пользователя по введенной строке поиска.</summary>
			/// <param name="q">подстрока, по которой будет производиться поиск</param>
			/// <param name="offset">смещение, необходимое для выборки определенного подмножества сообщений из списка найденных</param>
			/// <param name="count">количество сообщений, которое необходимо получить (но не более 100)</param>
			/// <returns>Ответ сервера в XML или JSON формате.</returns>
			private VKResponseBase search(string q, System.Int32? offset, System.Int32? count) {
				manager.AddValueByName("@q", q);
				manager.AddValueByName("@offset", offset);
				manager.AddValueByName("@count", count);
				return new VKResponseBase(GetResponse("search"), IsXMLResponse);
			}

			/// <summary>Возвращает список найденных личных сообщений текущего пользователя по введенной строке поиска.</summary>
			/// <param name="q">подстрока, по которой будет производиться поиск</param>
			/// <param name="offset">смещение, необходимое для выборки определенного подмножества сообщений из списка найденных</param>
			/// <param name="count">количество сообщений, которое необходимо получить (но не более 100)</param>
			/// <returns>Ответ сервера в XML или JSON формате.</returns>
			public VKResponseBase Search(string q, System.Int32? offset = null, System.Int32? count = null) {
				return search(q, offset, count);
			}
			#endregion

			#region messages.searchDialogs
			/// <summary>Возвращает список найденных диалогов текущего пользователя по введенной строке поиска.</summary>
			/// <param name="q">подстрока, по которой будет производиться поиск</param>
			/// <param name="fields">поля профилей собеседников, которые необходимо вернуть</param>
			/// <returns>Ответ сервера в XML или JSON формате.</returns>
			private VKResponseBase searchDialogs(string q, ProfileFields? fields) {
				manager.AddValueByName("@q", q);
				manager.AddValueByName("@fields", fields);
				return new VKResponseBase(GetResponse("searchDialogs"), IsXMLResponse);
			}

			/// <summary>Возвращает список найденных диалогов текущего пользователя по введенной строке поиска.</summary>
			/// <param name="q">подстрока, по которой будет производиться поиск</param>
			/// <param name="fields">поля профилей собеседников, которые необходимо вернуть</param>
			/// <returns>Ответ сервера в XML или JSON формате.</returns>
			public VKResponseBase SearchDialogs(string q, ProfileFields? fields = null) {
				return searchDialogs(q, fields);
			}
			#endregion

			#region messages.send
			/// <summary>Посылает сообщение.</summary>
			/// <param name="uid">ID пользователя (по умолчанию - текущий пользователь)</param>
			/// <param name="chat_id">ID беседы, к которой будет относиться сообщение </param>
			/// <param name="message">текст личного cообщения (является обязательным, если не задан параметр attachment) </param>
			/// <param name="attachment">медиа-приложения к личному сообщению, перечисленные через запятую</param>
			/// <param name="forward_messages">идентификаторы пересылаемых сообщений, перечисленные через запятую</param>
			/// <param name="title">заголовок сообщения</param>
			/// <param name="type">0  - обычное сообщение, 1 - сообщение из чата</param>
			/// <param name="lat">latitude, широта при добавлении метоположения</param>
			/// <param name="long">longitude, долгота при добавлении метоположения</param>
			/// <param name="guid">уникальный строковой идентификатор, предназначенный для предотвращения повторной отправки одинакового сообщения</param>
			/// <returns>Ответ сервера в XML или JSON формате.</returns>
			private VKResponseBase send(System.Int64? uid, string chat_id, string message, string attachment, string forward_messages, string title, string type, string lat, string @long, string guid) {
				manager.AddValueByName("@uid", uid);
				manager.AddValueByName("@chat_id", chat_id);
				manager.AddValueByName("@message", message);
				manager.AddValueByName("@attachment", attachment);
				manager.AddValueByName("@forward_messages", forward_messages);
				manager.AddValueByName("@title", title);
				manager.AddValueByName("@type", type);
				manager.AddValueByName("@lat", lat);
				manager.AddValueByName("@long", @long);
				manager.AddValueByName("@guid", guid);
				return new VKResponseBase(GetResponse("send"), IsXMLResponse);
			}
			#endregion

			#region messages.delete
			/// <summary>Удаляет сообщение.</summary>
			/// <param name="mids">Список идентификаторов сообщений, разделённых через запятую</param>
			/// <returns>Ответ сервера в XML или JSON формате.</returns>
			private VKResponseBase delete(IdList mids) {
				manager.AddValueByName("@mids", mids);
				return new VKResponseBase(GetResponse("delete"), IsXMLResponse);
			}

			/// <summary>Удаляет сообщение.</summary>
			/// <param name="mids">Список идентификаторов сообщений, разделённых через запятую</param>
			/// <returns>Ответ сервера в XML или JSON формате.</returns>
			public VKResponseBase Delete(IdList mids) {
				return delete(mids);
			}
			#endregion

			#region messages.deleteDialog
			/// <summary>Удаляет все личные сообщения в диалоге.</summary>
			/// <param name="uid">ID пользователя</param>
			/// <param name="chat_id">ID беседы, к которой будет относиться сообщение </param>
			/// <param name="offset">начиная с какого сообщения нужно удалить переписку</param>
			/// <param name="limit">Как много сообщений нужно удалить</param>
			/// <returns>Ответ сервера в XML или JSON формате.</returns>
			private VKResponseBase deleteDialog(System.Int64? uid, string chat_id, System.Int32? offset, string limit) {
				manager.AddValueByName("@uid", uid);
				manager.AddValueByName("@chat_id", chat_id);
				manager.AddValueByName("@offset", offset);
				manager.AddValueByName("@limit", limit);
				return new VKResponseBase(GetResponse("deleteDialog"), IsXMLResponse);
			}
			#endregion

			#region messages.restore
			/// <summary>Восстанавливает удаленное сообщение.</summary>
			/// <param name="mid">идентификатор сообщения</param>
			/// <returns>Ответ сервера в XML или JSON формате.</returns>
			private VKResponseBase restore(System.Int64? mid) {
				manager.AddValueByName("@mid", mid);
				return new VKResponseBase(GetResponse("restore"), IsXMLResponse);
			}

			/// <summary>Восстанавливает удаленное сообщение.</summary>
			/// <param name="mid">идентификатор сообщения</param>
			/// <returns>Ответ сервера в XML или JSON формате.</returns>
			public VKResponseBase Restore(System.Int64? mid) {
				return restore(mid);
			}
			#endregion

			#region messages.markAsNew
			/// <summary>Помечает сообщения, как непрочитанные.</summary>
			/// <param name="mids">список идентификаторов сообщений, разделенных запятой</param>
			/// <returns>Ответ сервера в XML или JSON формате.</returns>
			private VKResponseBase markAsNew(IdList mids) {
				manager.AddValueByName("@mids", mids);
				return new VKResponseBase(GetResponse("markAsNew"), IsXMLResponse);
			}

			/// <summary>Помечает сообщения, как непрочитанные.</summary>
			/// <param name="mids">список идентификаторов сообщений, разделенных запятой</param>
			/// <returns>Ответ сервера в XML или JSON формате.</returns>
			public VKResponseBase MarkAsNew(IdList mids) {
				return markAsNew(mids);
			}
			#endregion

			#region messages.markAsRead
			/// <summary></summary>
			/// <param name="mids">список идентификаторов сообщений, разделенных запятой</param>
			/// <returns>Ответ сервера в XML или JSON формате.</returns>
			private VKResponseBase markAsRead(IdList mids) {
				manager.AddValueByName("@mids", mids);
				return new VKResponseBase(GetResponse("markAsRead"), IsXMLResponse);
			}

			/// <summary></summary>
			/// <param name="mids">список идентификаторов сообщений, разделенных запятой</param>
			/// <returns>Ответ сервера в XML или JSON формате.</returns>
			public VKResponseBase MarkAsRead(IdList mids) {
				return markAsRead(mids);
			}
			#endregion

			#region messages.getHistory
			/// <summary></summary>
			/// <param name="uid">идентификатор пользователя, историю переписки с которым необходимо вернуть</param>
			/// <param name="chat_id">идентификатор беседы, историю переписки в которой необходимо вернуть</param>
			/// <param name="offset">смещение, необходимое для выборки определенного подмножества сообщений</param>
			/// <param name="count">количество сообщений, которое необходимо получить (но не более 200)</param>
			/// <param name="start_mid">идентификатор сообщения, начиная с которго необходимо получить последующие сообщения</param>
			/// <param name="rev">1 – возвращать сообщения в хронологическом порядке</param>
			/// <returns>Ответ сервера в XML или JSON формате.</returns>
			private VKResponseBase getHistory(System.Int64? uid, System.Int32? chat_id, System.Int32? offset, System.Int32? count, System.Int64? start_mid, bool? rev) {
				manager.AddValueByName("@uid", uid);
				manager.AddValueByName("@chat_id", chat_id);
				manager.AddValueByName("@offset", offset);
				manager.AddValueByName("@count", count);
				manager.AddValueByName("@start_mid", start_mid);
				manager.AddValueByName("@rev", rev);
				return new VKResponseBase(GetResponse("getHistory"), IsXMLResponse);
			}

			/// <summary></summary>
			/// <param name="uid">идентификатор пользователя, историю переписки с которым необходимо вернуть</param>
			/// <param name="offset">смещение, необходимое для выборки определенного подмножества сообщений</param>
			/// <param name="count">количество сообщений, которое необходимо получить (но не более 200)</param>
			/// <param name="start_mid">идентификатор сообщения, начиная с которго необходимо получить последующие сообщения</param>
			/// <param name="rev">1 – возвращать сообщения в хронологическом порядке</param>
			/// <returns>Ответ сервера в XML или JSON формате.</returns>
			public VKResponseBase GetHistory(long uid, System.Int32? offset = null, System.Int32? count = null, System.Int64? start_mid = null, bool? rev = null) {
				return getHistory(uid, null, offset, count, start_mid, rev);
			}
			#endregion

			#region messages.getLongPollServer
			/// <summary>Возвращает данные, необходимые для</summary>
			/// <returns>Ответ сервера в XML или JSON формате.</returns>
			private VKResponseBase getLongPollServer() {
				return new VKResponseBase(GetResponse("getLongPollServer"), IsXMLResponse);
			}
			#endregion

			#region messages.getChat
			/// <summary>Получает информацию о беседе.</summary>
			/// <param name="chat_id">идентификатор чата </param>
			/// <returns>Ответ сервера в XML или JSON формате.</returns>
			private VKResponseBase getChat(string chat_id) {
				manager.AddValueByName("@chat_id", chat_id);
				return new VKResponseBase(GetResponse("getChat"), IsXMLResponse);
			}
			#endregion

			#region messages.createChat
			/// <summary>Создаёт беседу с несколькими участниками.</summary>
			/// <param name="uids">список идентификаторов друзей текущего пользователя с которыми необходимо создать беседу</param>
			/// <param name="title">название мультидиалога</param>
			/// <returns>Ответ сервера в XML или JSON формате.</returns>
			private VKResponseBase createChat(string uids, string title) {
				manager.AddValueByName("@uids", uids);
				manager.AddValueByName("@title", title);
				return new VKResponseBase(GetResponse("createChat"), IsXMLResponse);
			}
			#endregion

			#region messages.editChat
			/// <summary>Изменяет название беседы.</summary>
			/// <param name="chat_id">идентификатор чата </param>
			/// <param name="title">название беседы</param>
			/// <returns>Ответ сервера в XML или JSON формате.</returns>
			private VKResponseBase editChat(string chat_id, string title) {
				manager.AddValueByName("@chat_id", chat_id);
				manager.AddValueByName("@title", title);
				return new VKResponseBase(GetResponse("editChat"), IsXMLResponse);
			}
			#endregion

			#region messages.getChatUsers
			/// <summary>Получить список пользователей мультидиалога по его id.</summary>
			/// <param name="chat_id">ID беседы, пользователей которой необходимо получить </param>
			/// <param name="fields">Перечисленные через запятую поля объектов пользователей, которые необходимо вернуть</param>
			/// <returns>Ответ сервера в XML или JSON формате.</returns>
			private VKResponseBase getChatUsers(string chat_id, ProfileFields? fields) {
				manager.AddValueByName("@chat_id", chat_id);
				manager.AddValueByName("@fields", fields);
				return new VKResponseBase(GetResponse("getChatUsers"), IsXMLResponse);
			}
			#endregion

			#region messages.addChatUser
			/// <summary>Добавляет в мультидиалог нового пользователя.</summary>
			/// <param name="chat_id">ID беседы, в которую необходимо добавить пользователя </param>
			/// <param name="uid">ID пользователя</param>
			/// <returns>Ответ сервера в XML или JSON формате.</returns>
			private VKResponseBase addChatUser(string chat_id, System.Int64? uid) {
				manager.AddValueByName("@chat_id", chat_id);
				manager.AddValueByName("@uid", uid);
				return new VKResponseBase(GetResponse("addChatUser"), IsXMLResponse);
			}
			#endregion

			#region messages.removeChatUser
			/// <summary>Исключает из мультидиалога пользователя, если текущий пользователь был создателем беседы либо пригласил исключаемого пользователя. Также может быть использован для выхода текущего пользователя из беседы, в которой он состоит.</summary>
			/// <param name="chat_id">ID беседы, из которой необходимо удалить пользователя</param>
			/// <param name="uid">ID пользователя</param>
			/// <returns>Ответ сервера в XML или JSON формате.</returns>
			private VKResponseBase removeChatUser(string chat_id, System.Int64? uid) {
				manager.AddValueByName("@chat_id", chat_id);
				manager.AddValueByName("@uid", uid);
				return new VKResponseBase(GetResponse("removeChatUser"), IsXMLResponse);
			}
			#endregion

			#region messages.setActivity
			/// <summary>Изменяет статус набора текста пользователем в диалоге.</summary>
			/// <param name="uid">ID пользователя (по умолчанию - текущий пользователь)</param>
			/// <param name="chat_id">ID беседы, к которой будет относиться сообщение </param>
			/// <param name="type">typing  - пользователь начал набирать текст </param>
			/// <returns>Ответ сервера в XML или JSON формате.</returns>
			private VKResponseBase setActivity(System.Int64? uid, string chat_id, string type) {
				manager.AddValueByName("@uid", uid);
				manager.AddValueByName("@chat_id", chat_id);
				manager.AddValueByName("@type", type);
				return new VKResponseBase(GetResponse("setActivity"), IsXMLResponse);
			}
			#endregion

			#region messages.getLastActivity
			/// <summary>Возвращает текущий статус и дату последней активности указанного пользователя.</summary>
			/// <param name="uid">ID пользователя, для которого нужно получить время активности</param>
			/// <returns>Ответ сервера в XML или JSON формате.</returns>
			private VKResponseBase getLastActivity(System.Int64? uid) {
				manager.AddValueByName("@uid", uid);
				return new VKResponseBase(GetResponse("getLastActivity"), IsXMLResponse);
			}
			#endregion
		}
	}
}
