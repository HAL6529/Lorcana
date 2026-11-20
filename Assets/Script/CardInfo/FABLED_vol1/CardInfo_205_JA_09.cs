using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_205_JA_09 : CardInfo
{
    public CardInfo_205_JA_09()
    {
        this.cardNo = "205_JA_09";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "女王";
        this.cardName2 = "傲慢な支配者";
        this.power = 2;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.EriWelli;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Queen, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Support };
        this.expansion = EnumController.Expansion.Fabled_vol1;
        this.title = EnumController.Title.SnowWhiteAndTheSevenDwarfs;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Epic;
    }
}
