

namespace OBS.Model
{
    /// <summary>
    /// ��ȡͰ��汾���õ����������
    /// </summary>
    public class GetBucketVersioningRequest : ObsBucketWebServiceRequest
    {

        internal override string GetAction()
        {
            return "GetBucketVersioning";
        }

    }
}
    
