using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_118_JA_03 : CardInfo
{
    public CardInfo_118_JA_03()
    {
        this.cardNo = "118_JA_03";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "‚Æ‚ñ‚Ü";
        this.cardName2 = "Žè‰º‚ÌƒnƒQƒ^ƒJ";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.DennyMinonne;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.RobinHood;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
