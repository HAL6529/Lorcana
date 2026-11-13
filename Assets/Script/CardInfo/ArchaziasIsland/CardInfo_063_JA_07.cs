using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_063_JA_07 : CardInfo
{
    public CardInfo_063_JA_07()
    {
        this.cardNo = "063_JA_07";
        this.inkCost = 5;
        this.availableInk = false;
        this.cardName1 = "ÉNÉçÉìÉN";
        this.cardName2 = "ÇÁÇ≠ÇøÇÒãCï™";
        this.power = 4;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.TonyBancroftAndLindsayWeyman;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst, EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Ward };
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.TheEmperorsNewGroove;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
