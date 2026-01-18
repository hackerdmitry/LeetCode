using System.Collections.Generic;

namespace LeetCode._2._Middle._3815._Design_Auction_System;

public class AuctionSystem
{
    private readonly Dictionary<int, ItemAuction> itemAuctions = new();

    public void AddBid(int userId, int itemId, int bidAmount)
    {
        var itemAuction = itemAuctions.GetValueOrDefault(itemId);
        if (itemAuction == null)
        {
            itemAuction = new ItemAuction();
            itemAuctions[itemId] = itemAuction;
        }

        itemAuction.AddOrUpdateBid(userId, bidAmount);
    }

    public void UpdateBid(int userId, int itemId, int newAmount)
    {
        AddBid(userId, itemId, newAmount);
    }

    public void RemoveBid(int userId, int itemId)
    {
        itemAuctions[itemId].RemoveBid(userId);
    }

    public int GetHighestBidder(int itemId)
    {
        var itemAuction = itemAuctions.GetValueOrDefault(itemId);
        return itemAuction?.GetHighestBidder() ?? -1;
    }

    private class ItemAuction
    {
        private readonly PriorityQueue<(int UserId, int Bid), long> bids = new();
        private readonly Dictionary<int, int> users = new();

        public void AddOrUpdateBid(int userId, int bidAmount)
        {
            users[userId] = bidAmount;
            bids.Enqueue((userId, bidAmount), -100_000L * bidAmount - userId);
        }

        public void RemoveBid(int userId)
        {
            users.Remove(userId);
        }

        public int GetHighestBidder()
        {
            while (bids.Count > 0)
            {
                var (userId, bid) = bids.Peek();
                if (users.TryGetValue(userId, out var currentBid) && currentBid == bid)
                    return userId;

                bids.Dequeue();
            }

            return -1;
        }
    }
}