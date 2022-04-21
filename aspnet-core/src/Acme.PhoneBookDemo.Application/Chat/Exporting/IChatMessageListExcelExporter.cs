using System.Collections.Generic;
using Abp;
using Acme.PhoneBookDemo.Chat.Dto;
using Acme.PhoneBookDemo.Dto;

namespace Acme.PhoneBookDemo.Chat.Exporting
{
    public interface IChatMessageListExcelExporter
    {
        FileDto ExportToFile(UserIdentifier user, List<ChatMessageExportDto> messages);
    }
}
