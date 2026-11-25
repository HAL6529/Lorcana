using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_220_JA_13 : CardInfo
{
    public CardInfo_220_JA_13()
    {
        this.cardNo = "220_JA_13";
        this.inkCost = 6;
        this.availableInk = false;
        this.cardName1 = "ウォーターヌース";
        this.cardName2 = "最高経営責任者";
        this.power = 5;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.EduFrancisco;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Monster };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.MonstersInc;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Epic;
    }
}
