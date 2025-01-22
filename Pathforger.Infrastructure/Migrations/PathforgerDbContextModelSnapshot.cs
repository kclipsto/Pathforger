﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PathforgerDb;

#nullable disable

namespace Pathforger.Infrastructure.Migrations
{
    [DbContext(typeof(PathforgerDbContext))]
    partial class PathforgerDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Pathforger.Entities.Entities.Actions.BasicActionEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ActionType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Actions")
                        .HasColumnType("int");

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FolderId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PublicationLicense")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PublicationRemaster")
                        .HasColumnType("bit");

                    b.Property<string>("PublicationTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rarity")
                        .HasColumnType("nvarchar(max)");

                    b.PrimitiveCollection<string>("Rules")
                        .HasColumnType("nvarchar(max)");

                    b.PrimitiveCollection<string>("Traits")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("BasicActions");

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("Pathforger.Entities.Entities.Ancestries.AncestryEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.PrimitiveCollection<string>("AdditionalLanguages")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AdditionalLanguagesCount")
                        .HasColumnType("int");

                    b.PrimitiveCollection<string>("AncestryRules")
                        .HasColumnType("nvarchar(max)");

                    b.PrimitiveCollection<string>("BoostsConstitution")
                        .HasColumnType("nvarchar(max)");

                    b.PrimitiveCollection<string>("BoostsDexterity")
                        .HasColumnType("nvarchar(max)");

                    b.PrimitiveCollection<string>("BoostsStrength")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CustomAdditionalLanguage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomLanguage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.PrimitiveCollection<string>("Flaws")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Hp")
                        .HasColumnType("int");

                    b.Property<string>("Img")
                        .HasColumnType("nvarchar(max)");

                    b.PrimitiveCollection<string>("Languages")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PublicationLicense")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PublicationRemaster")
                        .HasColumnType("bit");

                    b.Property<string>("PublicationTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rarity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Reach")
                        .HasColumnType("int");

                    b.Property<string>("Size")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Speed")
                        .HasColumnType("int");

                    b.PrimitiveCollection<string>("Traits")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Vision")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ancestries");
                });

            modelBuilder.Entity("Pathforger.Entities.Entities.Backgrounds.BackgroundEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.PrimitiveCollection<string>("BackgroundRules")
                        .HasColumnType("nvarchar(max)");

                    b.PrimitiveCollection<string>("Boosts0")
                        .HasColumnType("nvarchar(max)");

                    b.PrimitiveCollection<string>("Boosts1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PublicationLicense")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PublicationRemaster")
                        .HasColumnType("bit");

                    b.Property<string>("PublicationTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrainedSkillsCustom")
                        .HasColumnType("nvarchar(max)");

                    b.PrimitiveCollection<string>("TrainedSkillsLore")
                        .HasColumnType("nvarchar(max)");

                    b.PrimitiveCollection<string>("TrainedSkillsValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TraitsRarity")
                        .HasColumnType("nvarchar(max)");

                    b.PrimitiveCollection<string>("TraitsValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Backgrounds");
                });

            modelBuilder.Entity("Pathforger.Entities.Entities.Backgrounds.BackgroundFeatEntity", b =>
                {
                    b.Property<string>("BackgroundId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Key")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Img")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Uuid")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BackgroundId", "Key");

                    b.ToTable("BackgroundFeats");
                });

            modelBuilder.Entity("Pathforger.Entities.Entities.Classes.ClassEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AdditionalTrainedSkills")
                        .HasColumnType("int");

                    b.Property<bool>("AdvancedAttack")
                        .HasColumnType("bit");

                    b.PrimitiveCollection<string>("AncestryFeatLevels")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("CanAttack")
                        .HasColumnType("bit");

                    b.Property<bool>("CanSpellcast")
                        .HasColumnType("bit");

                    b.PrimitiveCollection<string>("ClassFeatLevels")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.PrimitiveCollection<string>("GeneralFeatLevels")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("HeavyDefense")
                        .HasColumnType("bit");

                    b.Property<int>("Hp")
                        .HasColumnType("int");

                    b.Property<string>("Img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KeyAbility")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LightDefense")
                        .HasColumnType("bit");

                    b.Property<bool>("MartialAttack")
                        .HasColumnType("bit");

                    b.Property<bool>("MediumDefense")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OtherAttackName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Perception")
                        .HasColumnType("int");

                    b.Property<string>("PublicationLicense")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PublicationRemaster")
                        .HasColumnType("bit");

                    b.Property<string>("PublicationTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SavingThrowsFortitude")
                        .HasColumnType("int");

                    b.Property<int>("SavingThrowsReflex")
                        .HasColumnType("int");

                    b.Property<int>("SavingThrowsWill")
                        .HasColumnType("int");

                    b.Property<bool>("SimpleAttack")
                        .HasColumnType("bit");

                    b.PrimitiveCollection<string>("SkillFeatLevels")
                        .HasColumnType("nvarchar(max)");

                    b.PrimitiveCollection<string>("SkillIncreaseLevels")
                        .HasColumnType("nvarchar(max)");

                    b.PrimitiveCollection<string>("TrainedSkillsValue")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TraitsRarity")
                        .HasColumnType("nvarchar(max)");

                    b.PrimitiveCollection<string>("TraitsValue")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("UnarmedAttack")
                        .HasColumnType("bit");

                    b.Property<bool>("UnarmoredDefense")
                        .HasColumnType("bit");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("Pathforger.Entities.Entities.Classes.ClassRuleEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ClassEntityId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Path")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PublicationLicense")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PublicationRemaster")
                        .HasColumnType("bit");

                    b.Property<string>("PublicationTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClassEntityId");

                    b.ToTable("ClassRules");
                });

            modelBuilder.Entity("Pathforger.Entities.Entities.Conditions.ConditionEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("ConditionIsValued")
                        .HasColumnType("bit");

                    b.Property<string>("ConditionValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DurationUnit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DurationValue")
                        .HasColumnType("int");

                    b.Property<string>("Group")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.PrimitiveCollection<string>("Overrides")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PublicationLicense")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PublicationRemaster")
                        .HasColumnType("bit");

                    b.Property<string>("PublicationTitle")
                        .HasColumnType("nvarchar(max)");

                    b.PrimitiveCollection<string>("ReferenceChildren")
                        .HasColumnType("nvarchar(max)");

                    b.PrimitiveCollection<string>("ReferenceImmunityFrom")
                        .HasColumnType("nvarchar(max)");

                    b.PrimitiveCollection<string>("ReferenceOverriddenBy")
                        .HasColumnType("nvarchar(max)");

                    b.PrimitiveCollection<string>("ReferenceOverrides")
                        .HasColumnType("nvarchar(max)");

                    b.PrimitiveCollection<string>("Rules")
                        .HasColumnType("nvarchar(max)");

                    b.PrimitiveCollection<string>("Traits")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Conditions");
                });

            modelBuilder.Entity("Pathforger.Entities.Entities.Equipment.DamageTypeEntity", b =>
                {
                    b.Property<string>("Key")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BaseType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DamageDice")
                        .HasColumnType("int");

                    b.Property<string>("DamageDie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DamageType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EquipmentRuleEntityId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Group")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Label")
                        .HasColumnType("nvarchar(max)");

                    b.PrimitiveCollection<string>("Predicate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Slug")
                        .HasColumnType("nvarchar(max)");

                    b.PrimitiveCollection<string>("Traits")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Key");

                    b.HasIndex("EquipmentRuleEntityId");

                    b.ToTable("DamageTypes");
                });

            modelBuilder.Entity("Pathforger.Entities.Entities.Equipment.EquipmentEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BaseItem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Bulk")
                        .HasColumnType("int");

                    b.Property<string>("ContainerId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EquipmentRarity")
                        .HasColumnType("nvarchar(max)");

                    b.PrimitiveCollection<string>("EquipmentTraits")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Hardness")
                        .HasColumnType("int");

                    b.Property<int>("HpMax")
                        .HasColumnType("int");

                    b.Property<int>("HpValue")
                        .HasColumnType("int");

                    b.Property<string>("Img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("MaterialGrade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaterialType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PriceName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PriceValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PublicationLicense")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PublicationRemaster")
                        .HasColumnType("bit");

                    b.Property<string>("PublicationTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Size")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Usage")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Equipment");
                });

            modelBuilder.Entity("Pathforger.Entities.Entities.Equipment.EquipmentRuleEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("EquipmentEntityId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PublicationLicense")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PublicationRemaster")
                        .HasColumnType("bit");

                    b.Property<string>("PublicationTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("EquipmentEntityId");

                    b.ToTable("EquipmentRules");
                });

            modelBuilder.Entity("Pathforger.Entities.Entities.Equipment.RuneEntity", b =>
                {
                    b.Property<string>("Key")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("EquipmentRuleEntityId")
                        .HasColumnType("nvarchar(450)");

                    b.PrimitiveCollection<string>("Predicate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Selector")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("Key");

                    b.HasIndex("EquipmentRuleEntityId");

                    b.ToTable("Runes");
                });

            modelBuilder.Entity("Pathforger.Entities.Entities.Feats.FeatEntity", b =>
                {
                    b.Property<string>("Uuid")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AncestryEntityId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ClassEntityId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FeatValueId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Uuid");

                    b.HasIndex("AncestryEntityId");

                    b.HasIndex("ClassEntityId");

                    b.HasIndex("FeatValueId");

                    b.ToTable("Feats");
                });

            modelBuilder.Entity("Pathforger.Entities.Entities.Feats.FeatValueEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ActionType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Actions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FeatType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.PrimitiveCollection<string>("Prerequisites")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PublicationLicense")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PublicationRemaster")
                        .HasColumnType("bit");

                    b.Property<string>("PublicationTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rarity")
                        .HasColumnType("nvarchar(max)");

                    b.PrimitiveCollection<string>("Rules")
                        .HasColumnType("nvarchar(max)");

                    b.PrimitiveCollection<string>("Traits")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("FeatValues");
                });

            modelBuilder.Entity("Pathforger.Entities.Entities.Spells.SpellEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Area")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cost")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Counteraction")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("DefenseBasic")
                        .HasColumnType("bit");

                    b.Property<string>("DefenseSave")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("DurationSustained")
                        .HasColumnType("bit");

                    b.Property<string>("DurationValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PublicationLicense")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PublicationRemaster")
                        .HasColumnType("bit");

                    b.Property<string>("PublicationTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Range")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rarity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Requirements")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Target")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Time")
                        .HasColumnType("nvarchar(max)");

                    b.PrimitiveCollection<string>("Traditions")
                        .HasColumnType("nvarchar(max)");

                    b.PrimitiveCollection<string>("Traits")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Spells");
                });

            modelBuilder.Entity("Pathforger.Entities.Entities.Actions.SkillActionEntity", b =>
                {
                    b.HasBaseType("Pathforger.Entities.Entities.Actions.BasicActionEntity");

                    b.Property<string>("CheckType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CriticalFailureEffect")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CriticalSuccessEffect")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DC")
                        .HasColumnType("int");

                    b.Property<string>("FailureEffect")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Skill")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SuccessEffect")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("SkillActions");
                });

            modelBuilder.Entity("Pathforger.Entities.Entities.Backgrounds.BackgroundFeatEntity", b =>
                {
                    b.HasOne("Pathforger.Entities.Entities.Backgrounds.BackgroundEntity", "Background")
                        .WithMany("Feats")
                        .HasForeignKey("BackgroundId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Background");
                });

            modelBuilder.Entity("Pathforger.Entities.Entities.Classes.ClassRuleEntity", b =>
                {
                    b.HasOne("Pathforger.Entities.Entities.Classes.ClassEntity", null)
                        .WithMany("ClassRules")
                        .HasForeignKey("ClassEntityId");
                });

            modelBuilder.Entity("Pathforger.Entities.Entities.Equipment.DamageTypeEntity", b =>
                {
                    b.HasOne("Pathforger.Entities.Entities.Equipment.EquipmentRuleEntity", null)
                        .WithMany("DamageTypes")
                        .HasForeignKey("EquipmentRuleEntityId");
                });

            modelBuilder.Entity("Pathforger.Entities.Entities.Equipment.EquipmentRuleEntity", b =>
                {
                    b.HasOne("Pathforger.Entities.Entities.Equipment.EquipmentEntity", null)
                        .WithMany("EquipmentRules")
                        .HasForeignKey("EquipmentEntityId");
                });

            modelBuilder.Entity("Pathforger.Entities.Entities.Equipment.RuneEntity", b =>
                {
                    b.HasOne("Pathforger.Entities.Entities.Equipment.EquipmentRuleEntity", null)
                        .WithMany("Runes")
                        .HasForeignKey("EquipmentRuleEntityId");
                });

            modelBuilder.Entity("Pathforger.Entities.Entities.Feats.FeatEntity", b =>
                {
                    b.HasOne("Pathforger.Entities.Entities.Ancestries.AncestryEntity", null)
                        .WithMany("Feats")
                        .HasForeignKey("AncestryEntityId");

                    b.HasOne("Pathforger.Entities.Entities.Classes.ClassEntity", null)
                        .WithMany("ClassFeats")
                        .HasForeignKey("ClassEntityId");

                    b.HasOne("Pathforger.Entities.Entities.Feats.FeatValueEntity", "FeatValue")
                        .WithMany()
                        .HasForeignKey("FeatValueId");

                    b.Navigation("FeatValue");
                });

            modelBuilder.Entity("Pathforger.Entities.Entities.Actions.SkillActionEntity", b =>
                {
                    b.HasOne("Pathforger.Entities.Entities.Actions.BasicActionEntity", null)
                        .WithOne()
                        .HasForeignKey("Pathforger.Entities.Entities.Actions.SkillActionEntity", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Pathforger.Entities.Entities.Ancestries.AncestryEntity", b =>
                {
                    b.Navigation("Feats");
                });

            modelBuilder.Entity("Pathforger.Entities.Entities.Backgrounds.BackgroundEntity", b =>
                {
                    b.Navigation("Feats");
                });

            modelBuilder.Entity("Pathforger.Entities.Entities.Classes.ClassEntity", b =>
                {
                    b.Navigation("ClassFeats");

                    b.Navigation("ClassRules");
                });

            modelBuilder.Entity("Pathforger.Entities.Entities.Equipment.EquipmentEntity", b =>
                {
                    b.Navigation("EquipmentRules");
                });

            modelBuilder.Entity("Pathforger.Entities.Entities.Equipment.EquipmentRuleEntity", b =>
                {
                    b.Navigation("DamageTypes");

                    b.Navigation("Runes");
                });
#pragma warning restore 612, 618
        }
    }
}
