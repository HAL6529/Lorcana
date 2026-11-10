using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_056_JA_03 : CardInfo
{
    public CardInfo_056_JA_03()
    {
        this.cardNo = "056_JA_03";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "‰Î‚Ì’¹";
        this.cardName2 = "”j‰ó‚Ì—Í";
        this.power = 6;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.HedvigH_S;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.Fantasia;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
