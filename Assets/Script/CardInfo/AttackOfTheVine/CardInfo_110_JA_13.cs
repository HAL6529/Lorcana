using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_110_JA_13 : CardInfo
{
    public CardInfo_110_JA_13()
    {
        this.cardNo = "110_JA_13";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "イズマ";
        this.cardName2 = "いちゃもんの多いお客様";
        this.power = 4;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.LissetteCarrera;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.TheEmperorsNewGroove;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
