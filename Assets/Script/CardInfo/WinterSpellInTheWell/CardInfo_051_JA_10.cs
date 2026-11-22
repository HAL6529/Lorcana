using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_051_JA_10 : CardInfo
{
    public CardInfo_051_JA_10()
    {
        this.cardNo = "051_JA_10";
        this.inkCost = 5;
        this.availableInk = false;
        this.cardName1 = "コールドストーン";
        this.cardName2 = "生まれ変わったサイボーグ";
        this.power = 5;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.CamKendellAndAlejandroHernandez;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Gargoyle };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpellInTheWell;
        this.title = EnumController.Title.TheBlackCauldron;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
