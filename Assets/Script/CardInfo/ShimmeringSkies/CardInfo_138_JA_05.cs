using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_138_JA_05 : CardInfo
{
    public CardInfo_138_JA_05()
    {
        this.cardNo = "138_JA_05";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ƒ`ƒƒƒJ";
        this.cardName2 = "‚¨‚Ä‚ñ‚Î–º";
        this.power = 4;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.RiantiHidayat;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.TheEmperorsNewGroove;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
