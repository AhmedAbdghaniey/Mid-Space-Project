// =====================================================================
// AppDbContext - Fluent API Configuration Required
// Add these inside OnModelCreating(ModelBuilder modelBuilder)
// =====================================================================

// 1. ChatParticipant - Composite Primary Key
modelBuilder.Entity<ChatParticipant>()
    .HasKey(cp => new { cp.ChatId, cp.UserId });

modelBuilder.Entity<ChatParticipant>()
    .HasOne(cp => cp.Chat)
    .WithMany(c => c.Participants)
    .HasForeignKey(cp => cp.ChatId);

modelBuilder.Entity<ChatParticipant>()
    .HasOne(cp => cp.User)
    .WithMany()
    .HasForeignKey(cp => cp.UserId);

// 2. DoctorFollow - Self-Referencing (Doctor follows Doctor)
modelBuilder.Entity<DoctorFollow>()
    .HasOne(df => df.FollowerDoctor)
    .WithMany(d => d.Following)
    .HasForeignKey(df => df.FollowerDoctorId)
    .OnDelete(DeleteBehavior.Restrict);

modelBuilder.Entity<DoctorFollow>()
    .HasOne(df => df.FollowedDoctor)
    .WithMany(d => d.Followers)
    .HasForeignKey(df => df.FollowedDoctorId)
    .OnDelete(DeleteBehavior.Restrict);

// 3. Message - SenderUserId foreign key
modelBuilder.Entity<Message>()
    .HasOne(m => m.Sender)
    .WithMany()
    .HasForeignKey(m => m.SenderUserId)
    .OnDelete(DeleteBehavior.Restrict);
