using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_189_JA_03 : CardInfo
{
    public CardInfo_189_JA_03()
    {
        this.cardNo = "189_JA_03";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ロビン・フッド";
        this.cardName2 = "人気の無法者";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.ValerioBuonfantino;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.RobinHood;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
