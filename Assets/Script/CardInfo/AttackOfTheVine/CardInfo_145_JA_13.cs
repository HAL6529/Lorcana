using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_145_JA_13 : CardInfo
{
    public CardInfo_145_JA_13()
    {
        this.cardNo = "145_JA_13";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ロズ";
        this.cardName2 = "あんたを見張ってるよ";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MatteoMarzocco;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Monster};
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.MonstersInc;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
