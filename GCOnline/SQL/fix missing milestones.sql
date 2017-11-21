delete from NET_DiaryTask
delete from NET_Milestone_CustomData
delete from NET_MatterMilestoneLink
delete from NET_MilestoneActivity_CustomData
delete from NET_MilestoneActivityCorrespondenceRecipientRoleLink
delete from NET_MilestoneActivity
delete from NET_Milestone

delete from NET_MilestoneGroup
delete from NET_MilestoneGroup_CustomData
delete from NET_MilestoneGroupType
update NET_Matter set MilestoneProcessID = NULL 
delete from NET_MilestoneProcess
delete from NET_MilestoneProcess_CustomData
delete from NET_MilestoneProcessVisibility

-- then run code gen 