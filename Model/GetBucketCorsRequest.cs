

namespace OBS.Model
{
    /// <summary>
    /// ��ȡͰ�Ŀ�����Դ�������õ����������
    /// </summary>
    public class GetBucketCorsRequest : ObsBucketWebServiceRequest
    {

        internal override string GetAction()
        {
            return "GetBucketCors";
        }

    }
}
    
