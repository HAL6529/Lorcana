using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_022_JA_05 : CardInfo
{
    public CardInfo_022_JA_05()
    {
        this.cardNo = "022_JA_05";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "ƒ}ƒŠƒAƒ“•P";
        this.cardName2 = "‹C•i‚ ‚é‹M•o";
        this.power = 4;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.JennaGray;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.RobinHood;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
