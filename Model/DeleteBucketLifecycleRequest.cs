

namespace OBS.Model
{
    /// <summary>
    /// ɾ��Ͱ�����������õ����������
    /// </summary>
    public class DeleteBucketLifecycleRequest : ObsBucketWebServiceRequest
    {

        internal override string GetAction()
        {
            return "DeleteLifecycle";
        }

    }
}
    
