using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_111_JA_03 : CardInfo
{
    public CardInfo_111_JA_03()
    {
        this.cardNo = "111_JA_03";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "ƒJƒJƒ‚ƒ‰";
        this.cardName2 = "‹ºˆÐ‚Ì‘Dˆõ";
        this.power = 3;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.BrianKesinger;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Pirate };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.Moana;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
