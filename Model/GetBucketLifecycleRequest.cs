


namespace OBS.Model
{
    /// <summary>
    /// ��ȡͰ�����������õ����������
    /// </summary>
    public class GetBucketLifecycleRequest : ObsBucketWebServiceRequest
    {

        internal override string GetAction()
        {
            return "GetBucketLifecycle";
        }

    }
}
    
