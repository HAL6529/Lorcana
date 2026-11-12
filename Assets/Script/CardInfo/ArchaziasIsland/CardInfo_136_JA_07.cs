using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_136_JA_07 : CardInfo
{
    public CardInfo_136_JA_07()
    {
        this.cardNo = "136_JA_07";
        this.inkCost = 6;
        this.availableInk = false;
        this.cardName1 = "野獣";
        this.cardName2 = "頭をかきむしるデザイナー";
        this.power = 5;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.Koni;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Prince, EnumController.Class.Inventor };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby, EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.BeautyAndTheBeast;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
