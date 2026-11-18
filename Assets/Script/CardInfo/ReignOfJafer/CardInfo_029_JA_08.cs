using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_029_JA_08 : CardInfo
{
    public CardInfo_029_JA_08()
    {
        this.cardNo = "029_JA_08";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ボルト";
        this.cardName2 = "七転び八起き";
        this.power = 0;
        this.toughness = 4;
        this.lore = 4;
        this.illustrator = EnumController.Illustrator.JoyAngAndJaimePuga;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber, EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.Bolt;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
