using System.Collections.Generic;
using Abp;
using DynasysSolution.Chat.Dto;
using DynasysSolution.Dto;

namespace DynasysSolution.Chat.Exporting
{
    public interface IChatMessageListExcelExporter
    {
        FileDto ExportToFile(UserIdentifier user, List<ChatMessageExportDto> messages);
    }
}
