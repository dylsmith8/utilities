-- declare variables that we are interested in 
declare @MatterFileReference varchar(50) = 'AGlodged 1.0';
declare @MatterKref varchar(50);
declare @StateID bigint;

-- get the MatterKref based on the FileReference 
select distinct @MatterKref = MatterKref from NET_Message where MatterID in (select ID from NET_Matter where FileReference = @MatterFileReference)

print(@MatterKref)

-- get the matter state 
select @StateID = StateID from NET_Matter where FileReference = @MatterFileReference;
print(@StateID)

select ID, [Description] from NET_MatterState where ID = @StateID;

-- Get ProgressDates Data 
select Registered, MatterTypeID from NET_ProgressDates where Registered is not null;

-- get all message data based on the matterkref 
select * from NET_Message where MatterKref = @MatterKref order by 1 desc;

select * from NET_MatterState