using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_047_JA_03 : CardInfo
{
    public CardInfo_047_JA_03()
    {
        this.cardNo = "047_JA_03";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "–‚–@‚Ì‚¶‚ã‚¤‚½‚ñ";
        this.cardName2 = "‹ó”ò‚Ô•~•¨";
        this.power = 2;
        this.toughness = 1;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.CoryGodbey;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
