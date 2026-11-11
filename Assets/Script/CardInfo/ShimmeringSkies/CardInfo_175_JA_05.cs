using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_175_JA_05 : CardInfo
{
    public CardInfo_175_JA_05()
    {
        this.cardNo = "175_JA_05";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "â§ã{åxîıï∫";
        this.cardName2 = "ÉEÉVÇ…Ç»Ç¡ÇΩÉÇÅ[Ç‚Çæ";
        this.power = 1;
        this.toughness = 7;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.ValerioBuonfantino;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.TheEmperorsNewGroove;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
