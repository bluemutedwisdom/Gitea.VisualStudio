﻿using Microsoft.TeamFoundation.Controls;

namespace Gitea.TeamFoundation
{
    static class Settings
    {
        public const string InvitationSectionId = "C2443FCC-6D62-4D31-B08A-C4DE70109C7F";
        public const int InvitationSectionPriority = 100;

        public const string ConnectSectionId = "FF7A257A-3AFB-44AC-B0F9-EA5F8789107E";
        public const int ConnectSectionPriority = 10;

        public const string HomeSectionId = "E200308C-D2D5-42DB-9C06-6FFED1E13097";
        public const int HomeSectionPriority = 10;

        public const string PublishSectionId = "3B5CEDDD-0AD3-469B-988A-9F8B71A5ACCF";
        public const int PublishSectionPriority = 10;

        public const string IssuesNavigationItemId = "31cdaebc-bf79-424e-963a-5ee5eb72dfed";
        public const int Issues = TeamExplorerNavigationItemPriority.GitCommits - 1;

        public const string MergeRequestsNavigationItemId = "338a9580-c50c-4e28-a339-eead17305f08";
        public const int MergeRequests = TeamExplorerNavigationItemPriority.GitCommits - 2;

       
        public const string WikiNavigationItemId = "bb5b8d03-a1ab-40da-ae4f-8f833ec12a0c";
        public const int Wiki = TeamExplorerNavigationItemPriority.Settings - 4;

        public const string ReleasesNavigationItemId = "bb5b8d03-a1ab-40da-ae4f-8f833ec12a0c";
        public const int Releases = TeamExplorerNavigationItemPriority.Settings - 5;
    }
}
