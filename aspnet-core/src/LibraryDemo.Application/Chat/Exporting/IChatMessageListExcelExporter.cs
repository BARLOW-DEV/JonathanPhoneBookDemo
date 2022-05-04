using System.Collections.Generic;
using Abp;
using LibraryDemo.Chat.Dto;
using LibraryDemo.Dto;

namespace LibraryDemo.Chat.Exporting
{
    public interface IChatMessageListExcelExporter
    {
        FileDto ExportToFile(UserIdentifier user, List<ChatMessageExportDto> messages);
    }
}
