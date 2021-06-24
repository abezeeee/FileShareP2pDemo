using System.Net;
using System.Net.PeerToPeer;

namespace FileShareP2pDemo.Domain.Models
{
    public class PeerEndPointsCollection
    {
        public PeerEndPointsCollection(PeerName peer, IPEndPointCollection ipEndPoint)
        {
            PeerHostName = peer;
            PeerEndPoints = ipEndPoint; 
        }

        public PeerName PeerHostName { get; set; }
        public IPEndPointCollection PeerEndPoints { get; set; }

    }
}
