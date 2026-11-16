using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_051_JA_06 : CardInfo
{
    public CardInfo_051_JA_06()
    {
        this.cardNo = "051_JA_06";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "–‚–@‚Ì‚¶‚ã‚¤‚½‚ñ";
        this.cardName2 = "‹ó”ò‚Ô‚·‚²‚¢ƒ„ƒc";
        this.power = 1;
        this.toughness = 3;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.RonBaird;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
