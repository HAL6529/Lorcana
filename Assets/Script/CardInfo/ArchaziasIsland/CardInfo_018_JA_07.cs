using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_018_JA_07 : CardInfo
{
    public CardInfo_018_JA_07()
    {
        this.cardNo = "018_JA_07";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ƒ{ƒ‹ƒg";
        this.cardName2 = "—Š‚à‚µ‚¢’‡ŠÔ";
        this.power = 2;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.EllieHorie;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Support };
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.Bolt;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
