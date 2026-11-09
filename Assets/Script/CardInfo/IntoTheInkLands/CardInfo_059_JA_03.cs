using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_059_JA_03 : CardInfo
{
    public CardInfo_059_JA_03()
    {
        this.cardNo = "059_JA_03";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "ÉAÅ[ÉXÉâ";
        this.cardName2 = "äCÇÃñÇèó";
        this.power = 3;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JohnLoren;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Villain, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.TheLittleMermaid;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
