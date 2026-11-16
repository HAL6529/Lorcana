using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_003_JA_06 : CardInfo
{
    public CardInfo_003_JA_06()
    {
        this.cardNo = "003_JA_06";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "В≠В№ВћГvБ[В≥Вс";
        this.cardName2 = "ВЌВњВЁВ¬ВћКCСѓ";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.Koni;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Pirate };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Support };
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.WinnieThePooh;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
