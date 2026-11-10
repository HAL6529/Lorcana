using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_205_JA_03 : CardInfo
{
    public CardInfo_205_JA_03()
    {
        this.cardNo = "205_JA_03";
        this.inkCost = 10;
        this.availableInk = false;
        this.cardName1 = "チェルナボーグ";
        this.cardName2 = "邪悪の化身";
        this.power = 9;
        this.toughness = 9;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.EvanaKisAndJochemVanGool;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.Fantasia;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
