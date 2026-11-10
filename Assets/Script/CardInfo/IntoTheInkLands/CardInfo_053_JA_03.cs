using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_053_JA_03 : CardInfo
{
    public CardInfo_053_JA_03()
    {
        this.cardNo = "053_JA_03";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ƒvƒA";
        this.cardName2 = "‚Ü‚ñ‚Ü‚é‚¨‚È‚©‚Ì‘Š–_";
        this.power = 2;
        this.toughness = 2;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.DennyMinonne;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally};
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.Moana;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
