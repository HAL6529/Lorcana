using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_114_JA_01 : CardInfo
{
    public CardInfo_114_JA_01()
    {
        this.cardNo = "114_JA_01";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ƒ}ƒEƒC";
        this.cardName2 = "‚Ý‚ñ‚È‚Ì‰p—Y";
        this.power = 6;
        this.toughness = 5;
        this.lore = 0;
        this.illustrator = "Pirel / MarcoGiorgianni";
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Deity };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Rush, EnumController.KeywordAvility.Reckless };
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.Moana;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
