
namespace OBS.Model
{
    /// <summary>
    /// ɾ��Ͱ�����������
    /// </summary>
    public class DeleteBucketRequest : ObsBucketWebServiceRequest
    {

        internal override string GetAction()
        {
            return "DeleteBucket";
        }

    }
}
    
