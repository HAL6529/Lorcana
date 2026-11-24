using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_157_JA_12 : CardInfo
{
    public CardInfo_157_JA_12()
    {
        this.cardNo = "157_JA_12";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "キーダ";
        this.cardName2 = "ふしぎ発見中";
        this.power = 3;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.OmarLozano;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.AtlantisTheLostEmpire;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
