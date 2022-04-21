using System.Collections.Generic;
using Acme.PhoneBookDemo.Auditing.Dto;
using Acme.PhoneBookDemo.Dto;

namespace Acme.PhoneBookDemo.Auditing.Exporting
{
    public interface IAuditLogListExcelExporter
    {
        FileDto ExportToFile(List<AuditLogListDto> auditLogListDtos);

        FileDto ExportToFile(List<EntityChangeListDto> entityChangeListDtos);
    }
}
