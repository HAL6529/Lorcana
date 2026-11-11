using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_108_JA_05 : CardInfo
{
    public CardInfo_108_JA_05()
    {
        this.cardNo = "108_JA_05";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ランシス・フラッガーバター";
        this.cardName2 = "チョコレート・チャージャー";
        this.power = 4;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.EllieHorie;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Racer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.WreckItRalph;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
