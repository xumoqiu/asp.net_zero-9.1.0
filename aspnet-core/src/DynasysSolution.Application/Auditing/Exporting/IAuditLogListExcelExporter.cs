using System.Collections.Generic;
using DynasysSolution.Auditing.Dto;
using DynasysSolution.Dto;

namespace DynasysSolution.Auditing.Exporting
{
    public interface IAuditLogListExcelExporter
    {
        FileDto ExportToFile(List<AuditLogListDto> auditLogListDtos);

        FileDto ExportToFile(List<EntityChangeListDto> entityChangeListDtos);
    }
}
