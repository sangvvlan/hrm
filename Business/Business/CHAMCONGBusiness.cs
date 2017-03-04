
using System.Data;
using DataObject;
using Data;

namespace Business
{ 
public class CHAMCONGBusiness
{

	public int Insert(CHAMCONG  ObjCHAMCONG) 
	{
		DataCHAMCONG  objData = new DataCHAMCONG();
		return  objData.DataInsertCHAMCONG(ObjCHAMCONG);
	}

	public int Update(CHAMCONG  ObjCHAMCONG) 
	{
		DataCHAMCONG  objData = new DataCHAMCONG();
		return  objData.DataUpdateCHAMCONG(ObjCHAMCONG);
	}

	public int Delete(CHAMCONG  ObjCHAMCONG) 
	{
		DataCHAMCONG  objData = new DataCHAMCONG();
		return  objData.DataDeleteCHAMCONG(ObjCHAMCONG);
	}

	public  DataTable GetList( ) 
	{
		DataCHAMCONG  objData = new DataCHAMCONG();
		return  objData.DataGetListCHAMCONG();
	}

	public  DataTable Details(CHAMCONG  ObjCHAMCONG) 
	{
		DataCHAMCONG  objData = new DataCHAMCONG();
		return  objData.DataDetailsCHAMCONG(ObjCHAMCONG);
	}

	public  DataTable DetailsByField(string FieldName,string  value) 
	{
		DataCHAMCONG  objData = new DataCHAMCONG();
		return  objData.DataDetailsByFieldCHAMCONG(FieldName,value);
	}

}
}
// End Class

