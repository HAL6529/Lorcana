using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_150_JA_13 : CardInfo
{
    public CardInfo_150_JA_13()
    {
        this.cardNo = "150_JA_13";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ハセガワさん";
        this.cardName2 = "くだもの屋さん";
        this.power = 3;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.SvetlozaraNikolova;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.LiloAndStitch;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
