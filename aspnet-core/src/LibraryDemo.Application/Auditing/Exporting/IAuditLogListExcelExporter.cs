using System.Collections.Generic;
using LibraryDemo.Auditing.Dto;
using LibraryDemo.Dto;

namespace LibraryDemo.Auditing.Exporting
{
    public interface IAuditLogListExcelExporter
    {
        FileDto ExportToFile(List<AuditLogListDto> auditLogListDtos);

        FileDto ExportToFile(List<EntityChangeListDto> entityChangeListDtos);
    }
}
